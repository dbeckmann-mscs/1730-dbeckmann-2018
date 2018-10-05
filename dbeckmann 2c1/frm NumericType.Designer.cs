namespace dbeckmann_2c1
{
    partial class frmNumType
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
            this.Input1textBox = new System.Windows.Forms.TextBox();
            this.btnSetMin = new System.Windows.Forms.Button();
            this.btnSetMax = new System.Windows.Forms.Button();
            this.Input2textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.byte1textBox = new System.Windows.Forms.TextBox();
            this.byte2textBox = new System.Windows.Forms.TextBox();
            this.byte3textBox = new System.Windows.Forms.TextBox();
            this.sbyte3textBox = new System.Windows.Forms.TextBox();
            this.sbyte2textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sbyte1textBox = new System.Windows.Forms.TextBox();
            this.short3textBox = new System.Windows.Forms.TextBox();
            this.short2textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.short1textBox = new System.Windows.Forms.TextBox();
            this.ushort3textBox = new System.Windows.Forms.TextBox();
            this.ushort2textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ushort1textBox = new System.Windows.Forms.TextBox();
            this.float3textBox = new System.Windows.Forms.TextBox();
            this.float2textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.float1textBox = new System.Windows.Forms.TextBox();
            this.ulong3textBox = new System.Windows.Forms.TextBox();
            this.ulong2textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ulong1textBox = new System.Windows.Forms.TextBox();
            this.uint3textBox = new System.Windows.Forms.TextBox();
            this.uint2textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uint1textBox = new System.Windows.Forms.TextBox();
            this.int3textBox = new System.Windows.Forms.TextBox();
            this.int2textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.int1textBox = new System.Windows.Forms.TextBox();
            this.decimal3textBox = new System.Windows.Forms.TextBox();
            this.decimal2textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.decimal1textBox = new System.Windows.Forms.TextBox();
            this.double3textBox = new System.Windows.Forms.TextBox();
            this.double2textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.double1textBox = new System.Windows.Forms.TextBox();
            this.long3textBox = new System.Windows.Forms.TextBox();
            this.long2textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.long1textBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Minusbutton = new System.Windows.Forms.Button();
            this.Multiplybutton = new System.Windows.Forms.Button();
            this.Dividebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1textBox
            // 
            this.Input1textBox.Location = new System.Drawing.Point(102, 90);
            this.Input1textBox.Name = "Input1textBox";
            this.Input1textBox.Size = new System.Drawing.Size(196, 20);
            this.Input1textBox.TabIndex = 0;
            this.Input1textBox.Text = "0";
            this.Input1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Input1textBox.TextChanged += new System.EventHandler(this.Input1textBox_TextChanged);
            // 
            // btnSetMin
            // 
            this.btnSetMin.Location = new System.Drawing.Point(219, 59);
            this.btnSetMin.Name = "btnSetMin";
            this.btnSetMin.Size = new System.Drawing.Size(79, 25);
            this.btnSetMin.TabIndex = 2;
            this.btnSetMin.Text = "Set Minimum";
            this.btnSetMin.UseVisualStyleBackColor = true;
            this.btnSetMin.Click += new System.EventHandler(this.btnSetMin_Click);
            // 
            // btnSetMax
            // 
            this.btnSetMax.Location = new System.Drawing.Point(421, 59);
            this.btnSetMax.Name = "btnSetMax";
            this.btnSetMax.Size = new System.Drawing.Size(79, 25);
            this.btnSetMax.TabIndex = 3;
            this.btnSetMax.Text = "Set Maximum";
            this.btnSetMax.UseVisualStyleBackColor = true;
            this.btnSetMax.Click += new System.EventHandler(this.btnSetMax_Click);
            // 
            // Input2textBox
            // 
            this.Input2textBox.Location = new System.Drawing.Point(304, 90);
            this.Input2textBox.Name = "Input2textBox";
            this.Input2textBox.Size = new System.Drawing.Size(196, 20);
            this.Input2textBox.TabIndex = 4;
            this.Input2textBox.Text = "0";
            this.Input2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Input2textBox.TextChanged += new System.EventHandler(this.Input2textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "byte";
            // 
            // byte1textBox
            // 
            this.byte1textBox.Location = new System.Drawing.Point(102, 116);
            this.byte1textBox.Name = "byte1textBox";
            this.byte1textBox.ReadOnly = true;
            this.byte1textBox.Size = new System.Drawing.Size(196, 20);
            this.byte1textBox.TabIndex = 5;
            this.byte1textBox.TabStop = false;
            this.byte1textBox.Text = "0";
            this.byte1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // byte2textBox
            // 
            this.byte2textBox.Location = new System.Drawing.Point(304, 116);
            this.byte2textBox.Name = "byte2textBox";
            this.byte2textBox.ReadOnly = true;
            this.byte2textBox.Size = new System.Drawing.Size(196, 20);
            this.byte2textBox.TabIndex = 7;
            this.byte2textBox.TabStop = false;
            this.byte2textBox.Text = "0";
            this.byte2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // byte3textBox
            // 
            this.byte3textBox.Location = new System.Drawing.Point(506, 116);
            this.byte3textBox.Name = "byte3textBox";
            this.byte3textBox.ReadOnly = true;
            this.byte3textBox.Size = new System.Drawing.Size(196, 20);
            this.byte3textBox.TabIndex = 8;
            this.byte3textBox.TabStop = false;
            this.byte3textBox.Text = "0";
            this.byte3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sbyte3textBox
            // 
            this.sbyte3textBox.Location = new System.Drawing.Point(506, 142);
            this.sbyte3textBox.Name = "sbyte3textBox";
            this.sbyte3textBox.ReadOnly = true;
            this.sbyte3textBox.Size = new System.Drawing.Size(196, 20);
            this.sbyte3textBox.TabIndex = 12;
            this.sbyte3textBox.TabStop = false;
            this.sbyte3textBox.Text = "0";
            this.sbyte3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sbyte2textBox
            // 
            this.sbyte2textBox.Location = new System.Drawing.Point(304, 142);
            this.sbyte2textBox.Name = "sbyte2textBox";
            this.sbyte2textBox.ReadOnly = true;
            this.sbyte2textBox.Size = new System.Drawing.Size(196, 20);
            this.sbyte2textBox.TabIndex = 11;
            this.sbyte2textBox.TabStop = false;
            this.sbyte2textBox.Text = "0";
            this.sbyte2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "sbyte";
            // 
            // sbyte1textBox
            // 
            this.sbyte1textBox.Location = new System.Drawing.Point(102, 142);
            this.sbyte1textBox.Name = "sbyte1textBox";
            this.sbyte1textBox.ReadOnly = true;
            this.sbyte1textBox.Size = new System.Drawing.Size(196, 20);
            this.sbyte1textBox.TabIndex = 9;
            this.sbyte1textBox.TabStop = false;
            this.sbyte1textBox.Text = "0";
            this.sbyte1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // short3textBox
            // 
            this.short3textBox.Location = new System.Drawing.Point(506, 168);
            this.short3textBox.Name = "short3textBox";
            this.short3textBox.ReadOnly = true;
            this.short3textBox.Size = new System.Drawing.Size(196, 20);
            this.short3textBox.TabIndex = 16;
            this.short3textBox.TabStop = false;
            this.short3textBox.Text = "0";
            this.short3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // short2textBox
            // 
            this.short2textBox.Location = new System.Drawing.Point(304, 168);
            this.short2textBox.Name = "short2textBox";
            this.short2textBox.ReadOnly = true;
            this.short2textBox.Size = new System.Drawing.Size(196, 20);
            this.short2textBox.TabIndex = 15;
            this.short2textBox.TabStop = false;
            this.short2textBox.Text = "0";
            this.short2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "short";
            // 
            // short1textBox
            // 
            this.short1textBox.Location = new System.Drawing.Point(102, 168);
            this.short1textBox.Name = "short1textBox";
            this.short1textBox.ReadOnly = true;
            this.short1textBox.Size = new System.Drawing.Size(196, 20);
            this.short1textBox.TabIndex = 13;
            this.short1textBox.TabStop = false;
            this.short1textBox.Text = "0";
            this.short1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ushort3textBox
            // 
            this.ushort3textBox.Location = new System.Drawing.Point(506, 194);
            this.ushort3textBox.Name = "ushort3textBox";
            this.ushort3textBox.ReadOnly = true;
            this.ushort3textBox.Size = new System.Drawing.Size(196, 20);
            this.ushort3textBox.TabIndex = 20;
            this.ushort3textBox.TabStop = false;
            this.ushort3textBox.Text = "0";
            this.ushort3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ushort2textBox
            // 
            this.ushort2textBox.Location = new System.Drawing.Point(304, 194);
            this.ushort2textBox.Name = "ushort2textBox";
            this.ushort2textBox.ReadOnly = true;
            this.ushort2textBox.Size = new System.Drawing.Size(196, 20);
            this.ushort2textBox.TabIndex = 19;
            this.ushort2textBox.TabStop = false;
            this.ushort2textBox.Text = "0";
            this.ushort2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ushort";
            // 
            // ushort1textBox
            // 
            this.ushort1textBox.Location = new System.Drawing.Point(102, 194);
            this.ushort1textBox.Name = "ushort1textBox";
            this.ushort1textBox.ReadOnly = true;
            this.ushort1textBox.Size = new System.Drawing.Size(196, 20);
            this.ushort1textBox.TabIndex = 17;
            this.ushort1textBox.TabStop = false;
            this.ushort1textBox.Text = "0";
            this.ushort1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // float3textBox
            // 
            this.float3textBox.Location = new System.Drawing.Point(506, 322);
            this.float3textBox.Name = "float3textBox";
            this.float3textBox.ReadOnly = true;
            this.float3textBox.Size = new System.Drawing.Size(196, 20);
            this.float3textBox.TabIndex = 36;
            this.float3textBox.TabStop = false;
            this.float3textBox.Text = "0";
            this.float3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // float2textBox
            // 
            this.float2textBox.Location = new System.Drawing.Point(304, 322);
            this.float2textBox.Name = "float2textBox";
            this.float2textBox.ReadOnly = true;
            this.float2textBox.Size = new System.Drawing.Size(196, 20);
            this.float2textBox.TabIndex = 35;
            this.float2textBox.TabStop = false;
            this.float2textBox.Text = "0";
            this.float2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "float";
            // 
            // float1textBox
            // 
            this.float1textBox.Location = new System.Drawing.Point(102, 322);
            this.float1textBox.Name = "float1textBox";
            this.float1textBox.ReadOnly = true;
            this.float1textBox.Size = new System.Drawing.Size(196, 20);
            this.float1textBox.TabIndex = 33;
            this.float1textBox.TabStop = false;
            this.float1textBox.Text = "0";
            this.float1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ulong3textBox
            // 
            this.ulong3textBox.Location = new System.Drawing.Point(506, 296);
            this.ulong3textBox.Name = "ulong3textBox";
            this.ulong3textBox.ReadOnly = true;
            this.ulong3textBox.Size = new System.Drawing.Size(196, 20);
            this.ulong3textBox.TabIndex = 32;
            this.ulong3textBox.TabStop = false;
            this.ulong3textBox.Text = "0";
            this.ulong3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ulong2textBox
            // 
            this.ulong2textBox.Location = new System.Drawing.Point(304, 296);
            this.ulong2textBox.Name = "ulong2textBox";
            this.ulong2textBox.ReadOnly = true;
            this.ulong2textBox.Size = new System.Drawing.Size(196, 20);
            this.ulong2textBox.TabIndex = 31;
            this.ulong2textBox.TabStop = false;
            this.ulong2textBox.Text = "0";
            this.ulong2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "ulong";
            // 
            // ulong1textBox
            // 
            this.ulong1textBox.Location = new System.Drawing.Point(102, 296);
            this.ulong1textBox.Name = "ulong1textBox";
            this.ulong1textBox.ReadOnly = true;
            this.ulong1textBox.Size = new System.Drawing.Size(196, 20);
            this.ulong1textBox.TabIndex = 29;
            this.ulong1textBox.TabStop = false;
            this.ulong1textBox.Text = "0";
            this.ulong1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uint3textBox
            // 
            this.uint3textBox.Location = new System.Drawing.Point(506, 246);
            this.uint3textBox.Name = "uint3textBox";
            this.uint3textBox.ReadOnly = true;
            this.uint3textBox.Size = new System.Drawing.Size(196, 20);
            this.uint3textBox.TabIndex = 28;
            this.uint3textBox.TabStop = false;
            this.uint3textBox.Text = "0";
            this.uint3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uint2textBox
            // 
            this.uint2textBox.Location = new System.Drawing.Point(304, 246);
            this.uint2textBox.Name = "uint2textBox";
            this.uint2textBox.ReadOnly = true;
            this.uint2textBox.Size = new System.Drawing.Size(196, 20);
            this.uint2textBox.TabIndex = 27;
            this.uint2textBox.TabStop = false;
            this.uint2textBox.Text = "0";
            this.uint2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "uint";
            // 
            // uint1textBox
            // 
            this.uint1textBox.Location = new System.Drawing.Point(102, 246);
            this.uint1textBox.Name = "uint1textBox";
            this.uint1textBox.ReadOnly = true;
            this.uint1textBox.Size = new System.Drawing.Size(196, 20);
            this.uint1textBox.TabIndex = 25;
            this.uint1textBox.TabStop = false;
            this.uint1textBox.Text = "0";
            this.uint1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // int3textBox
            // 
            this.int3textBox.Location = new System.Drawing.Point(506, 220);
            this.int3textBox.Name = "int3textBox";
            this.int3textBox.ReadOnly = true;
            this.int3textBox.Size = new System.Drawing.Size(196, 20);
            this.int3textBox.TabIndex = 24;
            this.int3textBox.TabStop = false;
            this.int3textBox.Text = "0";
            this.int3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // int2textBox
            // 
            this.int2textBox.Location = new System.Drawing.Point(304, 220);
            this.int2textBox.Name = "int2textBox";
            this.int2textBox.ReadOnly = true;
            this.int2textBox.Size = new System.Drawing.Size(196, 20);
            this.int2textBox.TabIndex = 23;
            this.int2textBox.TabStop = false;
            this.int2textBox.Text = "0";
            this.int2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "int";
            // 
            // int1textBox
            // 
            this.int1textBox.Location = new System.Drawing.Point(102, 220);
            this.int1textBox.Name = "int1textBox";
            this.int1textBox.ReadOnly = true;
            this.int1textBox.Size = new System.Drawing.Size(196, 20);
            this.int1textBox.TabIndex = 21;
            this.int1textBox.TabStop = false;
            this.int1textBox.Text = "0";
            this.int1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // decimal3textBox
            // 
            this.decimal3textBox.Location = new System.Drawing.Point(506, 374);
            this.decimal3textBox.Name = "decimal3textBox";
            this.decimal3textBox.ReadOnly = true;
            this.decimal3textBox.Size = new System.Drawing.Size(196, 20);
            this.decimal3textBox.TabIndex = 44;
            this.decimal3textBox.TabStop = false;
            this.decimal3textBox.Text = "0";
            this.decimal3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // decimal2textBox
            // 
            this.decimal2textBox.Location = new System.Drawing.Point(304, 374);
            this.decimal2textBox.Name = "decimal2textBox";
            this.decimal2textBox.ReadOnly = true;
            this.decimal2textBox.Size = new System.Drawing.Size(196, 20);
            this.decimal2textBox.TabIndex = 43;
            this.decimal2textBox.TabStop = false;
            this.decimal2textBox.Text = "0";
            this.decimal2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "decimal";
            // 
            // decimal1textBox
            // 
            this.decimal1textBox.Location = new System.Drawing.Point(102, 374);
            this.decimal1textBox.Name = "decimal1textBox";
            this.decimal1textBox.ReadOnly = true;
            this.decimal1textBox.Size = new System.Drawing.Size(196, 20);
            this.decimal1textBox.TabIndex = 41;
            this.decimal1textBox.TabStop = false;
            this.decimal1textBox.Text = "0";
            this.decimal1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // double3textBox
            // 
            this.double3textBox.Location = new System.Drawing.Point(506, 348);
            this.double3textBox.Name = "double3textBox";
            this.double3textBox.ReadOnly = true;
            this.double3textBox.Size = new System.Drawing.Size(196, 20);
            this.double3textBox.TabIndex = 40;
            this.double3textBox.TabStop = false;
            this.double3textBox.Text = "0";
            this.double3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // double2textBox
            // 
            this.double2textBox.Location = new System.Drawing.Point(304, 348);
            this.double2textBox.Name = "double2textBox";
            this.double2textBox.ReadOnly = true;
            this.double2textBox.Size = new System.Drawing.Size(196, 20);
            this.double2textBox.TabIndex = 39;
            this.double2textBox.TabStop = false;
            this.double2textBox.Text = "0";
            this.double2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "double";
            // 
            // double1textBox
            // 
            this.double1textBox.Location = new System.Drawing.Point(102, 348);
            this.double1textBox.Name = "double1textBox";
            this.double1textBox.ReadOnly = true;
            this.double1textBox.Size = new System.Drawing.Size(196, 20);
            this.double1textBox.TabIndex = 37;
            this.double1textBox.TabStop = false;
            this.double1textBox.Text = "0";
            this.double1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // long3textBox
            // 
            this.long3textBox.Location = new System.Drawing.Point(506, 272);
            this.long3textBox.Name = "long3textBox";
            this.long3textBox.ReadOnly = true;
            this.long3textBox.Size = new System.Drawing.Size(196, 20);
            this.long3textBox.TabIndex = 48;
            this.long3textBox.TabStop = false;
            this.long3textBox.Text = "0";
            this.long3textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // long2textBox
            // 
            this.long2textBox.Location = new System.Drawing.Point(304, 272);
            this.long2textBox.Name = "long2textBox";
            this.long2textBox.ReadOnly = true;
            this.long2textBox.Size = new System.Drawing.Size(196, 20);
            this.long2textBox.TabIndex = 47;
            this.long2textBox.TabStop = false;
            this.long2textBox.Text = "0";
            this.long2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "long";
            // 
            // long1textBox
            // 
            this.long1textBox.Location = new System.Drawing.Point(102, 272);
            this.long1textBox.Name = "long1textBox";
            this.long1textBox.ReadOnly = true;
            this.long1textBox.Size = new System.Drawing.Size(196, 20);
            this.long1textBox.TabIndex = 45;
            this.long1textBox.TabStop = false;
            this.long1textBox.Text = "0";
            this.long1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(506, 89);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(20, 20);
            this.Addbutton.TabIndex = 49;
            this.Addbutton.Text = "+";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Minusbutton
            // 
            this.Minusbutton.Location = new System.Drawing.Point(532, 89);
            this.Minusbutton.Name = "Minusbutton";
            this.Minusbutton.Size = new System.Drawing.Size(20, 20);
            this.Minusbutton.TabIndex = 50;
            this.Minusbutton.Text = "-";
            this.Minusbutton.UseVisualStyleBackColor = true;
            this.Minusbutton.Click += new System.EventHandler(this.Minusbutton_Click);
            // 
            // Multiplybutton
            // 
            this.Multiplybutton.Location = new System.Drawing.Point(558, 90);
            this.Multiplybutton.Name = "Multiplybutton";
            this.Multiplybutton.Size = new System.Drawing.Size(20, 20);
            this.Multiplybutton.TabIndex = 51;
            this.Multiplybutton.Text = "*";
            this.Multiplybutton.UseVisualStyleBackColor = true;
            this.Multiplybutton.Click += new System.EventHandler(this.Multiplybutton_Click);
            // 
            // Dividebutton
            // 
            this.Dividebutton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Dividebutton.Location = new System.Drawing.Point(584, 90);
            this.Dividebutton.Name = "Dividebutton";
            this.Dividebutton.Size = new System.Drawing.Size(20, 20);
            this.Dividebutton.TabIndex = 52;
            this.Dividebutton.Text = "/";
            this.Dividebutton.UseVisualStyleBackColor = true;
            this.Dividebutton.Click += new System.EventHandler(this.Dividebutton_Click);
            // 
            // frmNumType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dividebutton);
            this.Controls.Add(this.Multiplybutton);
            this.Controls.Add(this.Minusbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.long3textBox);
            this.Controls.Add(this.long2textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.long1textBox);
            this.Controls.Add(this.decimal3textBox);
            this.Controls.Add(this.decimal2textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.decimal1textBox);
            this.Controls.Add(this.double3textBox);
            this.Controls.Add(this.double2textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.double1textBox);
            this.Controls.Add(this.float3textBox);
            this.Controls.Add(this.float2textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.float1textBox);
            this.Controls.Add(this.ulong3textBox);
            this.Controls.Add(this.ulong2textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ulong1textBox);
            this.Controls.Add(this.uint3textBox);
            this.Controls.Add(this.uint2textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uint1textBox);
            this.Controls.Add(this.int3textBox);
            this.Controls.Add(this.int2textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.int1textBox);
            this.Controls.Add(this.ushort3textBox);
            this.Controls.Add(this.ushort2textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ushort1textBox);
            this.Controls.Add(this.short3textBox);
            this.Controls.Add(this.short2textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.short1textBox);
            this.Controls.Add(this.sbyte3textBox);
            this.Controls.Add(this.sbyte2textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbyte1textBox);
            this.Controls.Add(this.byte3textBox);
            this.Controls.Add(this.byte2textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.byte1textBox);
            this.Controls.Add(this.Input2textBox);
            this.Controls.Add(this.btnSetMax);
            this.Controls.Add(this.btnSetMin);
            this.Controls.Add(this.Input1textBox);
            this.Name = "frmNumType";
            this.Text = "dbeckmann Numeric Type Ranges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1textBox;
        private System.Windows.Forms.Button btnSetMin;
        private System.Windows.Forms.Button btnSetMax;
        private System.Windows.Forms.TextBox Input2textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox byte1textBox;
        private System.Windows.Forms.TextBox byte2textBox;
        private System.Windows.Forms.TextBox byte3textBox;
        private System.Windows.Forms.TextBox sbyte3textBox;
        private System.Windows.Forms.TextBox sbyte2textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sbyte1textBox;
        private System.Windows.Forms.TextBox short3textBox;
        private System.Windows.Forms.TextBox short2textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox short1textBox;
        private System.Windows.Forms.TextBox ushort3textBox;
        private System.Windows.Forms.TextBox ushort2textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ushort1textBox;
        private System.Windows.Forms.TextBox float3textBox;
        private System.Windows.Forms.TextBox float2textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox float1textBox;
        private System.Windows.Forms.TextBox ulong3textBox;
        private System.Windows.Forms.TextBox ulong2textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ulong1textBox;
        private System.Windows.Forms.TextBox uint3textBox;
        private System.Windows.Forms.TextBox uint2textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uint1textBox;
        private System.Windows.Forms.TextBox int3textBox;
        private System.Windows.Forms.TextBox int2textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox int1textBox;
        private System.Windows.Forms.TextBox decimal3textBox;
        private System.Windows.Forms.TextBox decimal2textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox decimal1textBox;
        private System.Windows.Forms.TextBox double3textBox;
        private System.Windows.Forms.TextBox double2textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox double1textBox;
        private System.Windows.Forms.TextBox long3textBox;
        private System.Windows.Forms.TextBox long2textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox long1textBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Minusbutton;
        private System.Windows.Forms.Button Multiplybutton;
        private System.Windows.Forms.Button Dividebutton;
    }
}

