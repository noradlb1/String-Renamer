Imports dnlib.DotNet
Imports dnlib.DotNet.Emit
Imports dnlib.DotNet.Writer
Imports System
Imports System.Windows.Forms
Imports System.Runtime.CompilerServices

Namespace Astro_Renamer
    Partial Public Class MainForm
        Inherits Form
        Private arguments As String() = {}
        Public Sub New(ByVal args As String())
            arguments = args
            InitializeComponent()
            ActiveControl = btnStart
        End Sub

        Private Sub btnExit_Click(sender As Object, ByVal e As EventArgs) Handles btnExit.Click
            Environment.Exit(0)
        End Sub
        Private Sub btnStart_Click_1(sender As Object, e As EventArgs) Handles btnStart.Click
            btnStart.Enabled = False
            processProgress.Value = 100

            Dim classBool = rnClass.Checked
            Dim asmblyBool = rnAsmbly.Checked
            Dim mduleBool = rnMdule.Checked
            Dim methodBool = rnMethod.Checked
            Dim fileBool = rnFile.Checked
            Dim stringBool = rnString.Checked
            Dim propertyBool = rnProperty.Checked
            Dim fieldBool = rnField.Checked
            Dim eventdefBool = rnEventdef.Checked
            Dim resourcesBool = rnResources.Checked
            Dim asmblyInfoBool = rnAsmblyInfo.Checked

            Dim loadPath = fileLocationBox.Text
            Dim [module] As ModuleDefMD = Nothing
            Try
                [module] = ModuleDefMD.Load(loadPath)
            Catch
                MessageBox.Show("Entered file location is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                processProgress.Value = 0
                btnStart.Enabled = True
                Return
            End Try

            Dim oldValue = originalStrBox.Text
            Dim newValue = renamedStrBox.Text

            Dim countx = RenameProcess([module], oldValue, newValue, classBool, asmblyBool, mduleBool, methodBool, fileBool, stringBool, propertyBool, fieldBool, eventdefBool, resourcesBool, asmblyInfoBool)

            Dim file = loadPath

            Try
                If file.ToLower().EndsWith(".exe") Then
                    Dim newname = file.Substring(0, file.Length - 4) & "-astro.exe"
                    If newname.Contains(oldValue) AndAlso fileBool Then
                        newname = newname.Replace(oldValue, newValue)
                    End If
                    Dim path = newname
                    [module].Write(path, New ModuleWriterOptions([module]) With {
        .Logger = DummyLogger.NoThrowInstance
})
                End If
                If file.ToLower().EndsWith(".dll") Then
                    Dim newname = file.Substring(0, file.Length - 4) & "-astro.dll"
                    If newname.Contains(oldValue) AndAlso fileBool Then
                        newname = newname.Replace(oldValue, newValue)
                    End If
                    Dim path = newname
                    [module].Write(path, New ModuleWriterOptions([module]) With {
        .Logger = DummyLogger.NoThrowInstance
})
                End If
                If arguments.Length > 0 Then
                    Environment.Exit(0)
                Else
                    Call MessageBox.Show("Rename process is successfully completed!" & Microsoft.VisualBasic.Constants.vbLf & "Renamed Things: " & countx.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch a As Exception
                Call MessageBox.Show($"An error occured while saving file!
Exception: {a.Message.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            processProgress.Value = 0
            btnStart.Enabled = True
        End Sub

        Private Function RenameProcess(ByVal moduleDef As ModuleDefMD, ByVal originalStr As String, ByVal renamedStr As String, ByVal classBool As Boolean, ByVal asmblyBool As Boolean, ByVal mduleBool As Boolean, ByVal methodBool As Boolean, ByVal fileBool As Boolean, ByVal stringBool As Boolean, ByVal propertyBool As Boolean, ByVal fieldBool As Boolean, ByVal eventdefBool As Boolean, ByVal resourcesBool As Boolean, ByVal asmblyInfoBool As Boolean) As Integer
            Dim count = 0
            For Each type In moduleDef.GetTypes()
                If type.IsGlobalModuleType Then Continue For
                For Each methodDef In type.Methods
                    If Not methodDef.HasBody OrElse Not methodDef.Body.HasInstructions Then Continue For
                    For i = 0 To methodDef.Body.Instructions.Count - 1
                        If methodDef.Body.Instructions(i).OpCode IsNot OpCodes.Ldstr Then Continue For
                        Dim plainText = methodDef.Body.Instructions(i).Operand.ToString()
                        Dim operand = plainText
                        If plainText.Contains(originalStr) AndAlso stringBool Then
                            Loglist("Replaced: " & operand)
                            operand = plainText.Replace(originalStr, renamedStr)
                            count += 1
                        End If
                        methodDef.Body.Instructions(i).Operand = operand
                    Next
                    methodDef.Body.SimplifyBranches()
                Next

                If type.Name.Contains(originalStr) AndAlso classBool Then
                    Loglist("Replaced: " & type.Name.ToString())
                    type.Name = type.Name.Replace(originalStr, renamedStr)
                    count += 1
                End If
                For Each [property] In type.Properties
                    If [property].Name.Contains(originalStr) AndAlso propertyBool Then
                        Loglist("Replaced: " & [property].Name.ToString())
                        [property].Name = [property].Name.Replace(originalStr, renamedStr)
                        count += 1
                    End If
                Next
                For Each fields In type.Fields
                    If fields.Name.Contains(originalStr) AndAlso fieldBool Then
                        Loglist("Replaced: " & fields.Name.ToString())
                        fields.Name = fields.Name.Replace(originalStr, renamedStr)
                        count += 1
                    End If
                Next
                For Each eventdef In type.Events
                    If eventdef.Name.Contains(originalStr) AndAlso eventdefBool Then
                        Loglist("Replaced: " & eventdef.Name.ToString())
                        eventdef.Name = eventdef.Name.Replace(originalStr, renamedStr)
                        count += 1
                    End If
                Next
                For Each method In type.Methods
                    If method.IsConstructor Then Continue For
                    If method.Name.Contains(originalStr) AndAlso methodBool Then
                        Loglist("Replaced: " & method.Name.ToString())
                        method.Name = method.Name.Replace(originalStr, renamedStr)
                        count += 1
                    End If
                Next
            Next
            If moduleDef.Name.Contains(originalStr) AndAlso mduleBool Then
                Loglist("Replaced: " & moduleDef.Name.ToString())
                moduleDef.Name = moduleDef.Name.Replace(originalStr, renamedStr)
                count += 1
            End If
            If moduleDef.Assembly.Name.Contains(originalStr) AndAlso asmblyBool Then
                Loglist("Replaced: " & moduleDef.Assembly.Name.ToString())
                moduleDef.Assembly.Name = moduleDef.Assembly.Name.Replace(originalStr, renamedStr)
                count += 1
            End If

            For Each res In moduleDef.Resources
                If res.Name.Contains(originalStr) AndAlso resourcesBool Then
                    Loglist("Replaced: " & res.Name.ToString())
                    res.Name = res.Name.Replace(originalStr, renamedStr)
                    count += 1
                End If
            Next



            Return count
        End Function

        Private Sub fileLocationBox_DragDrop(sender As Object, e As DragEventArgs) Handles fileLocationBox.DragDrop
            Dim text = e.Data.GetData(DataFormats.FileDrop)
            Dim tb As TextBox = TryCast(sender, TextBox)
            If tb IsNot Nothing Then
                tb.Text = String.Format("{0}", CType(text, String())(0))
            End If
        End Sub
        Private Sub fileLocationBox_DragEnter(sender As Object, e As DragEventArgs) Handles fileLocationBox.DragEnter
            Dim text = e.Data.GetData(DataFormats.FileDrop)
            Dim tb As TextBox = TryCast(sender, TextBox)
            If tb IsNot Nothing Then
                tb.Text = String.Format("{0}", CType(text, String())(0))
            End If
        End Sub

        Private Sub allBox_Click(sender As Object, e As EventArgs) Handles allBox.CheckedChanged
            rnAsmbly.toggleCheck()
            rnClass.toggleCheck()
            rnEventdef.toggleCheck()
            rnField.toggleCheck()
            rnFile.toggleCheck()
            rnMdule.toggleCheck()
            rnMethod.toggleCheck()
            rnProperty.toggleCheck()
            rnString.toggleCheck()
            rnAsmblyInfo.toggleCheck()
            rnResources.toggleCheck()
            allBox.CheckState = CheckState.Indeterminate
        End Sub

        Public Sub Loglist(ByVal text As String)
            logListBox.Items.Add(text)
        End Sub

        Private Sub MainForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
            If arguments.Length > 0 Then
                originalStrBox.Text = arguments(0)
                renamedStrBox.Text = arguments(1)
                fileLocationBox.Text = arguments(2)
                If arguments(2).StartsWith("""") AndAlso arguments(2).EndsWith("""") Then
                    fileLocationBox.Text = arguments(2).Replace("""", "")
                End If

                btnStart.PerformClick()
            End If
        End Sub

    End Class

    Public Module Func2
        <Extension()>
        Public Sub toggleCheck(ByVal checkBox As CheckBox)
            checkBox.Checked = Not checkBox.Checked
        End Sub
    End Module
End Namespace
