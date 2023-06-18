using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using KeyGen.Properties;


namespace KeyGen;

public class KeyGenForm : Form
{
	private static Dictionary<int, string> products = new Dictionary<int, string>();

	private bool mouseDown;

	private Point lastLocation;



	private IContainer components;

	private Button btnGernerate;

	private Button btnExit;

	private TextBox tbOrderNo;

	private Label label4;

	private Label label1;

	private TextBox tbRegCode;

	private Label label2;

	public KeyGenForm()
	{
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs args)
		{
			string resourceName = new AssemblyName(args.Name).Name + ".dll";
			string name = Array.Find(GetType().Assembly.GetManifestResourceNames(), (string element) => element.EndsWith(resourceName));
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return Assembly.Load(array);
		};
		InitializeComponent();
		
		GenerateAndSetSerial();
	}

	private void KeyGenForm_Load(object sender, EventArgs e)
	{
	}

	private void btnGernerate_Click(object sender, EventArgs e)
	{
		GenerateAndSetSerial();
	}

	private void GenerateAndSetSerial()
	{
		tbRegCode.Text = TangibleKeyGen.generateKey();
		tbOrderNo.Text = TangibleKeyGen.generateOrderNumber();
	}

	

	private void pbLogo_Click(object sender, EventArgs e)
	{
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void KeyGen_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			base.Location = new Point(base.Location.X - lastLocation.X + e.X, base.Location.Y - lastLocation.Y + e.Y);
			Update();
		}
	}

	private void KeyGen_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
	}

	private void KeyGen_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.Location;
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void KeyGenForm_Load_1(object sender, EventArgs e)
	{
		
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	private void marquee1_Click(object sender, EventArgs e)
	{
	}

	private void scrollText_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            this.btnGernerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGernerate
            // 
            this.btnGernerate.BackColor = System.Drawing.Color.Black;
            this.btnGernerate.ForeColor = System.Drawing.Color.White;
            this.btnGernerate.Location = new System.Drawing.Point(178, 327);
            this.btnGernerate.Margin = new System.Windows.Forms.Padding(6);
            this.btnGernerate.Name = "btnGernerate";
            this.btnGernerate.Size = new System.Drawing.Size(214, 42);
            this.btnGernerate.TabIndex = 0;
            this.btnGernerate.Text = "Generate";
            this.btnGernerate.UseVisualStyleBackColor = false;
            this.btnGernerate.Click += new System.EventHandler(this.btnGernerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(524, 327);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.BackColor = System.Drawing.Color.Black;
            this.tbOrderNo.ForeColor = System.Drawing.Color.White;
            this.tbOrderNo.Location = new System.Drawing.Point(178, 235);
            this.tbOrderNo.Margin = new System.Windows.Forms.Padding(6);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.ReadOnly = true;
            this.tbOrderNo.Size = new System.Drawing.Size(484, 29);
            this.tbOrderNo.TabIndex = 4;
            this.tbOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order No:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reg Code:";
            // 
            // tbRegCode
            // 
            this.tbRegCode.BackColor = System.Drawing.Color.Black;
            this.tbRegCode.ForeColor = System.Drawing.Color.White;
            this.tbRegCode.Location = new System.Drawing.Point(178, 165);
            this.tbRegCode.Margin = new System.Windows.Forms.Padding(6);
            this.tbRegCode.Name = "tbRegCode";
            this.tbRegCode.ReadOnly = true;
            this.tbRegCode.Size = new System.Drawing.Size(484, 29);
            this.tbRegCode.TabIndex = 16;
            this.tbRegCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tangible Software - All Products KeyGen";
            // 
            // KeyGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(680, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRegCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGernerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "KeyGenForm";
            this.Load += new System.EventHandler(this.KeyGenForm_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeyGen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KeyGen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KeyGen_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
