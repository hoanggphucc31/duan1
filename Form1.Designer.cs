
namespace Đèn_giao_thông
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redled = new SymbolFactoryDotNet.StandardControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yellowled = new SymbolFactoryDotNet.StandardControl();
            this.greenled = new SymbolFactoryDotNet.StandardControl();
            ((System.ComponentModel.ISupportInitialize)(this.redled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenled)).BeginInit();
            this.SuspendLayout();
            // 
            // redled
            // 
            this.redled.AnalogIntValue1 = ((short)(0));
            this.redled.AnalogValue1 = 0D;
            this.redled.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.redled.BackColor = System.Drawing.Color.Transparent;
            this.redled.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.redled.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.redled.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Red, "Band2"));
            this.redled.BlinkColor = System.Drawing.Color.Red;
            this.redled.Category = "1Btn.cat2";
            this.redled.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("redled.DebugData"));
            this.redled.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.redled.Location = new System.Drawing.Point(182, 124);
            this.redled.Name = "redled";
            this.redled.Size = new System.Drawing.Size(99, 87);
            this.redled.SymbolHandle = ((long)(2528572));
            this.redled.TabIndex = 0;
            this.redled.Load += new System.EventHandler(this.standardControl1_Load);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yellowled
            // 
            this.yellowled.AnalogIntValue1 = ((short)(0));
            this.yellowled.AnalogValue1 = 0D;
            this.yellowled.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.yellowled.BackColor = System.Drawing.Color.Transparent;
            this.yellowled.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.yellowled.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.yellowled.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Yellow, "Band2"));
            this.yellowled.BlinkColor = System.Drawing.Color.Red;
            this.yellowled.Category = "1Btn.cat2";
            this.yellowled.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("yellowled.DebugData"));
            this.yellowled.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.yellowled.Location = new System.Drawing.Point(304, 124);
            this.yellowled.Name = "yellowled";
            this.yellowled.Size = new System.Drawing.Size(99, 87);
            this.yellowled.SymbolHandle = ((long)(2528572));
            this.yellowled.TabIndex = 1;
            // 
            // greenled
            // 
            this.greenled.AnalogIntValue1 = ((short)(0));
            this.greenled.AnalogValue1 = 0D;
            this.greenled.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.greenled.BackColor = System.Drawing.Color.Transparent;
            this.greenled.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.greenled.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.greenled.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.BlinkShaded, System.Drawing.Color.Lime, "Band2"));
            this.greenled.BlinkColor = System.Drawing.Color.Red;
            this.greenled.Category = "1Btn.cat2";
            this.greenled.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("greenled.DebugData"));
            this.greenled.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.greenled.Location = new System.Drawing.Point(441, 124);
            this.greenled.Name = "greenled";
            this.greenled.Size = new System.Drawing.Size(99, 87);
            this.greenled.SymbolHandle = ((long)(2528572));
            this.greenled.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greenled);
            this.Controls.Add(this.yellowled);
            this.Controls.Add(this.redled);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SymbolFactoryDotNet.StandardControl redled;
        private System.Windows.Forms.Timer timer1;
        private SymbolFactoryDotNet.StandardControl yellowled;
        private SymbolFactoryDotNet.StandardControl greenled;
    }
}

