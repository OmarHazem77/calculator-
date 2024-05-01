namespace WinFormsApp8
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
   

  
        partial class Form1
        {
            /// <summary>
            ///  Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button0 = new Button();
            Button1 = new Button();
            Button2 = new Button();
            Button3 = new Button();
            Button4 = new Button();
            Button5 = new Button();
            Button6 = new Button();
            Button7 = new Button();
            Button8 = new Button();
            Button9 = new Button();
            ButtonSum = new Button();
            ButtonDiv = new Button();
            ButtonMult = new Button();
            ButtonSub = new Button();
            ButtonDot = new Button();
            ButtonPre = new Button();
            ButtonCalc = new Button();
            ButtonClear = new Button();
            Screen = new TextBox();
            SuspendLayout();
            // 
            // Button0
            // 
            Button0.Font = new Font("famely", 20f);
            Button0.ForeColor = Color.White;
            Button0.Location = new Point(8, 408);
            Button0.Margin = new Padding(2, 2, 2, 2);
            Button0.Name = "Button0";
            Button0.Size = new Size(64, 64);
            Button0.TabIndex = 0;
            Button0.Text = "0";
            Button0.Click += Button0_Click;
            // 
            // Button1
            // 
            Button1.Font = new Font("famely", 20f);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(8, 320);
            Button1.Margin = new Padding(2, 2, 2, 2);
            Button1.Name = "Button1";
            Button1.Size = new Size(64, 64);
            Button1.TabIndex = 1;
            Button1.Text = "1";
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("famely", 20f);
            Button2.ForeColor = Color.White;
            Button2.Location = new Point(96, 320);
            Button2.Margin = new Padding(2, 2, 2, 2);
            Button2.Name = "Button2";
            Button2.Size = new Size(64, 64);
            Button2.TabIndex = 2;
            Button2.Text = "2";
            Button2.Click += Button2_Click;
            // 
            // Button3
            // 
            Button3.Font = new Font("famely", 20f);
            Button3.ForeColor = Color.White;
            Button3.Location = new Point(184, 320);
            Button3.Margin = new Padding(2, 2, 2, 2);
            Button3.Name = "Button3";
            Button3.Size = new Size(64, 64);
            Button3.TabIndex = 3;
            Button3.Text = "3";
            Button3.Click += Button3_Click;
            // 
            // Button4
            // 
            Button4.Font = new Font("famely", 20f);
            Button4.ForeColor = Color.White;
            Button4.Location = new Point(8, 232);
            Button4.Margin = new Padding(2, 2, 2, 2);
            Button4.Name = "Button4";
            Button4.Size = new Size(64, 64);
            Button4.TabIndex = 4;
            Button4.Text = "4";
            Button4.Click += Button4_Click;
            // 
            // Button5
            // 
            Button5.Font = new Font("famely", 20f);
            Button5.ForeColor = Color.White;
            Button5.Location = new Point(96, 232);
            Button5.Margin = new Padding(2, 2, 2, 2);
            Button5.Name = "Button5";
            Button5.Size = new Size(64, 64);
            Button5.TabIndex = 5;
            Button5.Text = "5";
            Button5.Click += Button5_Click;
            // 
            // Button6
            // 
            Button6.Font = new Font("famely", 20f);
            Button6.ForeColor = Color.White;
            Button6.Location = new Point(184, 232);
            Button6.Margin = new Padding(2, 2, 2, 2);
            Button6.Name = "Button6";
            Button6.Size = new Size(64, 64);
            Button6.TabIndex = 6;
            Button6.Text = "6";
            Button6.Click += Button6_Click;
            // 
            // Button7
            // 
            Button7.Font = new Font("famely", 20f);
            Button7.ForeColor = Color.White;
            Button7.Location = new Point(8, 144);
            Button7.Margin = new Padding(2, 2, 2, 2);
            Button7.Name = "Button7";
            Button7.Size = new Size(64, 64);
            Button7.TabIndex = 7;
            Button7.Text = "7";
            Button7.Click += Button7_Click;
            // 
            // Button8
            // 
            Button8.Font = new Font("famely", 20f);
            Button8.ForeColor = Color.White;
            Button8.Location = new Point(96, 144);
            Button8.Margin = new Padding(2, 2, 2, 2);
            Button8.Name = "Button8";
            Button8.Size = new Size(64, 64);
            Button8.TabIndex = 8;
            Button8.Text = "8";
            Button8.Click += Button8_Click;
            // 
            // Button9
            // 
            Button9.Font = new Font("famely", 20f);
            Button9.ForeColor = Color.White;
            Button9.Location = new Point(184, 144);
            Button9.Margin = new Padding(2, 2, 2, 2);
            Button9.Name = "Button9";
            Button9.Size = new Size(64, 64);
            Button9.TabIndex = 9;
            Button9.Text = "9";
            Button9.Click += Button9_Click;
            // 
            // ButtonSum
            // 
            ButtonSum.Font = new Font("famely", 20f);
            ButtonSum.ForeColor = Color.Black;
            ButtonSum.Location = new Point(272, 320);
            ButtonSum.Margin = new Padding(2, 2, 2, 2);
            ButtonSum.Name = "ButtonSum";
            ButtonSum.Size = new Size(64, 64);
            ButtonSum.TabIndex = 10;
            ButtonSum.Text = "+";
            ButtonSum.Click += ButtonSum_Click;
            // 
            // ButtonDiv
            // 
            ButtonDiv.Font = new Font("famely", 20f);
            ButtonDiv.ForeColor = Color.Black;
            ButtonDiv.Location = new Point(272, 232);
            ButtonDiv.Margin = new Padding(2, 2, 2, 2);
            ButtonDiv.Name = "ButtonDiv";
            ButtonDiv.Size = new Size(64, 64);
            ButtonDiv.TabIndex = 11;
            ButtonDiv.Text = "/";
            ButtonDiv.Click += ButtonDiv_Click;
            // 
            // ButtonMult
            // 
            ButtonMult.Font = new Font("famely", 20f);
            ButtonMult.ForeColor = Color.Black;
            ButtonMult.Location = new Point(184, 408);
            ButtonMult.Margin = new Padding(2, 2, 2, 2);
            ButtonMult.Name = "ButtonMult";
            ButtonMult.Size = new Size(64, 64);
            ButtonMult.TabIndex = 12;
            ButtonMult.Text = "x";
            ButtonMult.Click += ButtonMult_Click;
            // 
            // ButtonSub
            // 
            ButtonSub.Font = new Font("famely", 20f);
            ButtonSub.ForeColor = Color.Black;
            ButtonSub.Location = new Point(272, 408);
            ButtonSub.Margin = new Padding(2, 2, 2, 2);
            ButtonSub.Name = "ButtonSub";
            ButtonSub.Size = new Size(64, 64);
            ButtonSub.TabIndex = 13;
            ButtonSub.Text = "-";
            ButtonSub.Click += ButtonSub_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("famely", 20f);
            ButtonDot.ForeColor = Color.Black;
            ButtonDot.Location = new Point(96, 408);
            ButtonDot.Margin = new Padding(2, 2, 2, 2);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(64, 64);
            ButtonDot.TabIndex = 14;
            ButtonDot.Text = ".";
            ButtonDot.Click += ButtonDot_Click;
            // 
            // ButtonPre
            // 
            ButtonPre.Font = new Font("famely", 20f);
            ButtonPre.ForeColor = Color.Black;
            ButtonPre.Location = new Point(272, 144);
            ButtonPre.Margin = new Padding(2, 2, 2, 2);
            ButtonPre.Name = "ButtonPre";
            ButtonPre.Size = new Size(64, 64);
            ButtonPre.TabIndex = 15;
            ButtonPre.Text = "%";
            ButtonPre.Click += ButtonPre_Click;
            // 
            // ButtonCalc
            // 
            ButtonCalc.Font = new Font("famely", 20f);
            ButtonCalc.ForeColor = Color.Black;
            ButtonCalc.Location = new Point(184, 488);
            ButtonCalc.Margin = new Padding(2, 2, 2, 2);
            ButtonCalc.Name = "ButtonCalc";
            ButtonCalc.Size = new Size(152, 64);
            ButtonCalc.TabIndex = 15;
            ButtonCalc.Text = "=";
            ButtonCalc.Click += ButtonCalc_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Font = new Font("famely", 20f);
            ButtonClear.ForeColor = Color.Black;
            ButtonClear.Location = new Point(8, 488);
            ButtonClear.Margin = new Padding(2, 2, 2, 2);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(152, 64);
            ButtonClear.TabIndex = 15;
            ButtonClear.Text = "Clear";
            ButtonClear.Click += ButtonClear_Click;
            // 
            // Screen
            // 
            Screen.BackColor = Color.DarkGoldenrod;
            Screen.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Screen.Location = new Point(8, 16);
            Screen.Margin = new Padding(2, 2, 2, 2);
            Screen.Multiline = true;
            Screen.Name = "Screen";
            Screen.Size = new Size(329, 97);
            Screen.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(413, 600);
            Controls.Add(Button0);
            Controls.Add(Button1);
            Controls.Add(Button2);
            Controls.Add(Button3);
            Controls.Add(Button4);
            Controls.Add(Button5);
            Controls.Add(Button6);
            Controls.Add(Button7);
            Controls.Add(Button8);
            Controls.Add(Button9);
            Controls.Add(ButtonSum);
            Controls.Add(ButtonSub);
            Controls.Add(ButtonMult);
            Controls.Add(ButtonDiv);
            Controls.Add(ButtonDot);
            Controls.Add(ButtonPre);
            Controls.Add(ButtonCalc);
            Controls.Add(ButtonClear);
            Controls.Add(Screen);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Calc";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button Button1;
            private Button Button2;
            private Button Button3;
            private Button Button4;
            private Button Button5;
            private Button Button6;
            private Button Button7;
            private Button Button8;
            private Button Button9;
            private Button Button0;
            private Button ButtonMult;
            private Button ButtonDiv;
            private Button ButtonSum;
            private Button ButtonSub;
            private Button ButtonDot;
            private Button ButtonCalc;
            private Button ButtonClear;
            private TextBox Screen;
            private Button ButtonPre;



            #endregion
        }
    }

