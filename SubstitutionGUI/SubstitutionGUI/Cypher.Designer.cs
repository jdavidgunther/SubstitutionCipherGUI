namespace SubstitutionGUI
{
    partial class Cypher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encode = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.Codes = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.codeOutput = new System.Windows.Forms.RichTextBox();
            this.Invalid = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(147, 107);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(127, 43);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(423, 107);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(127, 43);
            this.Decode.TabIndex = 1;
            this.Decode.Text = "Decode";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Codes
            // 
            this.Codes.Location = new System.Drawing.Point(147, 46);
            this.Codes.Name = "Codes";
            this.Codes.Size = new System.Drawing.Size(403, 20);
            this.Codes.TabIndex = 2;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(336, 20);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(31, 13);
            this.Input.TabIndex = 3;
            this.Input.Text = "Input";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(328, 176);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(39, 13);
            this.Output.TabIndex = 4;
            this.Output.Text = "Output";
            // 
            // codeOutput
            // 
            this.codeOutput.Location = new System.Drawing.Point(147, 213);
            this.codeOutput.Name = "codeOutput";
            this.codeOutput.Size = new System.Drawing.Size(403, 26);
            this.codeOutput.TabIndex = 5;
            this.codeOutput.Text = "";
            // 
            // Invalid
            // 
            this.Invalid.Location = new System.Drawing.Point(319, 82);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(61, 21);
            this.Invalid.TabIndex = 6;
            this.Invalid.Text = "";
            // 
            // Cypher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 261);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.codeOutput);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Codes);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Encode);
            this.Name = "Cypher";
            this.Text = "Cypher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.TextBox Codes;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.RichTextBox codeOutput;
        private System.Windows.Forms.RichTextBox Invalid;
    }
}