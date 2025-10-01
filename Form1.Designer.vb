<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        entry_box = New TextBox()
        Label_inpt = New Label()
        Button_exit = New Button()
        Button_c = New Button()
        Button_ce = New Button()
        Button_equal = New Button()
        Button_percent = New Button()
        Button_divide = New Button()
        negetive = New Button()
        MS = New Button()
        MR = New Button()
        MC = New Button()
        times = New Button()
        minus = New Button()
        plus = New Button()
        result = New TextBox()
        equation = New TextBox()
        memory = New TextBox()
        Label_equ = New Label()
        Label_mem = New Label()
        label_result = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(791, 477)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' entry_box
        ' 
        entry_box.Location = New Point(143, 82)
        entry_box.Name = "entry_box"
        entry_box.Size = New Size(421, 27)
        entry_box.TabIndex = 1
        ' 
        ' Label_inpt
        ' 
        Label_inpt.AutoSize = True
        Label_inpt.Location = New Point(94, 85)
        Label_inpt.Name = "Label_inpt"
        Label_inpt.Size = New Size(43, 20)
        Label_inpt.TabIndex = 2
        Label_inpt.Text = "Input"
        ' 
        ' Button_exit
        ' 
        Button_exit.Location = New Point(587, 319)
        Button_exit.Name = "Button_exit"
        Button_exit.Size = New Size(136, 29)
        Button_exit.TabIndex = 3
        Button_exit.Text = "Exit"
        Button_exit.UseVisualStyleBackColor = True
        ' 
        ' Button_c
        ' 
        Button_c.Location = New Point(652, 281)
        Button_c.Name = "Button_c"
        Button_c.Size = New Size(58, 32)
        Button_c.TabIndex = 4
        Button_c.Text = "C"
        Button_c.UseVisualStyleBackColor = True
        ' 
        ' Button_ce
        ' 
        Button_ce.Location = New Point(587, 281)
        Button_ce.Name = "Button_ce"
        Button_ce.Size = New Size(59, 32)
        Button_ce.TabIndex = 5
        Button_ce.Text = "CE"
        Button_ce.UseVisualStyleBackColor = True
        ' 
        ' Button_equal
        ' 
        Button_equal.Location = New Point(587, 246)
        Button_equal.Name = "Button_equal"
        Button_equal.Size = New Size(136, 29)
        Button_equal.TabIndex = 6
        Button_equal.Text = "="
        Button_equal.UseVisualStyleBackColor = True
        ' 
        ' Button_percent
        ' 
        Button_percent.Location = New Point(716, 124)
        Button_percent.Name = "Button_percent"
        Button_percent.Size = New Size(58, 29)
        Button_percent.TabIndex = 7
        Button_percent.Text = "%"
        Button_percent.UseVisualStyleBackColor = True
        ' 
        ' Button_divide
        ' 
        Button_divide.Location = New Point(652, 124)
        Button_divide.Name = "Button_divide"
        Button_divide.Size = New Size(58, 29)
        Button_divide.TabIndex = 8
        Button_divide.Text = "/"
        Button_divide.UseVisualStyleBackColor = True
        ' 
        ' negetive
        ' 
        negetive.Location = New Point(587, 121)
        negetive.Name = "negetive"
        negetive.Size = New Size(59, 33)
        negetive.TabIndex = 9
        negetive.Text = "+/-"
        negetive.UseVisualStyleBackColor = True
        ' 
        ' MS
        ' 
        MS.Location = New Point(453, 121)
        MS.Name = "MS"
        MS.Size = New Size(62, 33)
        MS.TabIndex = 10
        MS.Text = "MS"
        MS.UseVisualStyleBackColor = True
        ' 
        ' MR
        ' 
        MR.Location = New Point(319, 121)
        MR.Name = "MR"
        MR.Size = New Size(70, 35)
        MR.TabIndex = 11
        MR.Text = "MR"
        MR.UseVisualStyleBackColor = True
        ' 
        ' MC
        ' 
        MC.Location = New Point(196, 121)
        MC.Name = "MC"
        MC.Size = New Size(70, 32)
        MC.TabIndex = 12
        MC.Text = "MC"
        MC.UseVisualStyleBackColor = True
        ' 
        ' times
        ' 
        times.Location = New Point(716, 85)
        times.Name = "times"
        times.Size = New Size(63, 24)
        times.TabIndex = 13
        times.Text = "*"
        times.UseVisualStyleBackColor = True
        ' 
        ' minus
        ' 
        minus.Location = New Point(652, 82)
        minus.Name = "minus"
        minus.Size = New Size(58, 27)
        minus.TabIndex = 14
        minus.Text = "-"
        minus.UseVisualStyleBackColor = True
        ' 
        ' plus
        ' 
        plus.Location = New Point(587, 81)
        plus.Name = "plus"
        plus.Size = New Size(59, 29)
        plus.TabIndex = 15
        plus.Text = "+"
        plus.UseVisualStyleBackColor = True
        ' 
        ' result
        ' 
        result.Location = New Point(143, 333)
        result.Name = "result"
        result.ReadOnly = True
        result.Size = New Size(421, 27)
        result.TabIndex = 16
        ' 
        ' equation
        ' 
        equation.Location = New Point(143, 286)
        equation.Name = "equation"
        equation.ReadOnly = True
        equation.Size = New Size(421, 27)
        equation.TabIndex = 17
        ' 
        ' memory
        ' 
        memory.Location = New Point(143, 168)
        memory.Name = "memory"
        memory.ReadOnly = True
        memory.Size = New Size(421, 27)
        memory.TabIndex = 18
        ' 
        ' Label_equ
        ' 
        Label_equ.AutoSize = True
        Label_equ.Location = New Point(69, 293)
        Label_equ.Name = "Label_equ"
        Label_equ.Size = New Size(68, 20)
        Label_equ.TabIndex = 19
        Label_equ.Text = "Equation"
        ' 
        ' Label_mem
        ' 
        Label_mem.AutoSize = True
        Label_mem.Location = New Point(69, 171)
        Label_mem.Name = "Label_mem"
        Label_mem.Size = New Size(64, 20)
        Label_mem.TabIndex = 20
        Label_mem.Text = "Memory"
        ' 
        ' label_result
        ' 
        label_result.AutoSize = True
        label_result.Location = New Point(84, 336)
        label_result.Name = "label_result"
        label_result.Size = New Size(49, 20)
        label_result.TabIndex = 21
        label_result.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(806, 501)
        Controls.Add(label_result)
        Controls.Add(Label_mem)
        Controls.Add(Label_equ)
        Controls.Add(memory)
        Controls.Add(equation)
        Controls.Add(result)
        Controls.Add(plus)
        Controls.Add(minus)
        Controls.Add(times)
        Controls.Add(MC)
        Controls.Add(MR)
        Controls.Add(MS)
        Controls.Add(negetive)
        Controls.Add(Button_divide)
        Controls.Add(Button_percent)
        Controls.Add(Button_equal)
        Controls.Add(Button_ce)
        Controls.Add(Button_c)
        Controls.Add(Button_exit)
        Controls.Add(Label_inpt)
        Controls.Add(entry_box)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents entry_box As TextBox
    Friend WithEvents Label_inpt As Label
    Friend WithEvents Button_exit As Button
    Friend WithEvents Button_c As Button
    Friend WithEvents Button_ce As Button
    Friend WithEvents Button_equal As Button
    Friend WithEvents Button_percent As Button
    Friend WithEvents Button_divide As Button
    Friend WithEvents negetive As Button
    Friend WithEvents MS As Button
    Friend WithEvents MR As Button
    Friend WithEvents MC As Button
    Friend WithEvents times As Button
    Friend WithEvents minus As Button
    Friend WithEvents plus As Button
    Friend WithEvents result As TextBox
    Friend WithEvents equation As TextBox
    Friend WithEvents memory As TextBox
    Friend WithEvents Label_equ As Label
    Friend WithEvents Label_mem As Label
    Friend WithEvents label_result As Label

End Class
