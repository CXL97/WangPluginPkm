﻿using PKHeX.Core;
using System;
using System.Windows.Forms;

namespace WangPlugin
{
    internal class RNGForm : Form
    {
        private Button Overworld8;
        private Button Method2;
        private Button Method4;
        private Button XDColo;
        private Button Roaming8b;
        private Button Method1;
        private ISaveFileProvider SAV { get; }
        private IPKMView Editor { get; }
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public RNGForm(ISaveFileProvider sav, IPKMView editor)
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        {
            SAV = sav;
            Editor = editor;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.Method1 = new System.Windows.Forms.Button();
            this.Overworld8 = new System.Windows.Forms.Button();
            this.Method2 = new System.Windows.Forms.Button();
            this.Method4 = new System.Windows.Forms.Button();
            this.XDColo = new System.Windows.Forms.Button();
            this.Roaming8b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Method1
            // 
            this.Method1.Location = new System.Drawing.Point(24, 31);
            this.Method1.Name = "Method1";
            this.Method1.Size = new System.Drawing.Size(97, 38);
            this.Method1.TabIndex = 0;
            this.Method1.Text = "Method1RNG";
            this.Method1.UseVisualStyleBackColor = true;
            this.Method1.Click += new System.EventHandler(this.Method1_Click);
            // 
            // Overworld8
            // 
            this.Overworld8.Location = new System.Drawing.Point(24, 157);
            this.Overworld8.Name = "Overworld8";
            this.Overworld8.Size = new System.Drawing.Size(97, 38);
            this.Overworld8.TabIndex = 1;
            this.Overworld8.Text = "Overworld8RNG";
            this.Overworld8.UseVisualStyleBackColor = true;
            this.Overworld8.Click += new System.EventHandler(this.Overworld8_Click);
            // 
            // Method2
            // 
            this.Method2.Location = new System.Drawing.Point(159, 31);
            this.Method2.Name = "Method2";
            this.Method2.Size = new System.Drawing.Size(99, 38);
            this.Method2.TabIndex = 2;
            this.Method2.Text = "Method2RNG";
            this.Method2.UseVisualStyleBackColor = true;
            this.Method2.Click += new System.EventHandler(this.Method2_Click);
            // 
            // Method4
            // 
            this.Method4.Location = new System.Drawing.Point(24, 91);
            this.Method4.Name = "Method4";
            this.Method4.Size = new System.Drawing.Size(99, 38);
            this.Method4.TabIndex = 3;
            this.Method4.Text = "Method4RNG";
            this.Method4.UseVisualStyleBackColor = true;
            this.Method4.Click += new System.EventHandler(this.Method4_Click);
            // 
            // XDColo
            // 
            this.XDColo.Location = new System.Drawing.Point(159, 91);
            this.XDColo.Name = "XDColo";
            this.XDColo.Size = new System.Drawing.Size(99, 38);
            this.XDColo.TabIndex = 4;
            this.XDColo.Text = "XDColoRNG";
            this.XDColo.UseVisualStyleBackColor = true;
            this.XDColo.Click += new System.EventHandler(this.XDColo_Click);
            // 
            // Roaming8b
            // 
            this.Roaming8b.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Roaming8b.Location = new System.Drawing.Point(159, 157);
            this.Roaming8b.Name = "Roaming8b";
            this.Roaming8b.Size = new System.Drawing.Size(99, 38);
            this.Roaming8b.TabIndex = 5;
            this.Roaming8b.Text = "Roaming8bRNG";
            this.Roaming8b.UseVisualStyleBackColor = true;
            this.Roaming8b.Click += new System.EventHandler(this.Roaming8b_Click);
            // 
            // RNGForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Roaming8b);
            this.Controls.Add(this.XDColo);
            this.Controls.Add(this.Method4);
            this.Controls.Add(this.Method2);
            this.Controls.Add(this.Overworld8);
            this.Controls.Add(this.Method1);
            this.Name = "RNGForm";
            this.ResumeLayout(false);

        }
        private void Method1_Click(object sender, EventArgs e)
        {
            var seed = Util.Rand32();
            while (true)
            {
                var pkm = Method1RNG.GenPkm(Editor.Data, seed);
                
             if (GetShinyXor(pkm.PID, pkm.TID, pkm.SID) < 8)
                {
                    pkm.RefreshChecksum();
                    MessageBox.Show($"过啦！");
                    Editor.PopulateFields(pkm, false);
                    SAV.ReloadSlots();
                    break;
                }
                seed = Method1RNG.Next(seed);
            }
        }
        private void Method2_Click(object sender, EventArgs e)
        {
            var seed = Util.Rand32();
            while (true)
            {
                var pkm = Method2RNG.GenPkm(Editor.Data, seed);

                if (GetShinyXor(pkm.PID, pkm.TID, pkm.SID) < 8)
                {
                    pkm.RefreshChecksum();
                    MessageBox.Show($"过啦！");
                    Editor.PopulateFields(pkm, false);
                    SAV.ReloadSlots();
                    break;
                }
                seed = Method2RNG.Next(seed);
            }
        }
        private void Method4_Click(object sender, EventArgs e)
        {
            var seed = Util.Rand32();
            while (true)
            {
                var pkm = Method4RNG.GenPkm(Editor.Data, seed);

                if (GetShinyXor(pkm.PID, pkm.TID, pkm.SID) < 8)
                {
                    pkm.RefreshChecksum();
                    MessageBox.Show($"过啦！");
                    Editor.PopulateFields(pkm, false);
                    SAV.ReloadSlots();
                    break;
                }
                seed = Method4RNG.Next(seed);
            }
        }
        private void XDColo_Click(object sender, EventArgs e)
        {
            var seed = Util.Rand32();
            while (true)
            {
                var pkm = XDColoRNG.GenPkm(Editor.Data, seed);

                if (GetShinyXor(pkm.PID, pkm.TID, pkm.SID) < 8)
                {
                    pkm.RefreshChecksum();
                    MessageBox.Show($"过啦！");
                    Editor.PopulateFields(pkm, false);
                    SAV.ReloadSlots();
                    break;
                }
                seed = XDColoRNG.Next(seed);
            }
        }
        private void Overworld8_Click(object sender, EventArgs e)
        {
            var seed = Util.Rand32();
            while (true)
            {
                var pkm = Overworld8RNG.GenPkm(Editor.Data, seed, Editor.Data.TID, Editor.Data.SID);

                if (GetShinyXor(pkm.PID, pkm.TID, pkm.SID) < 16)
                {
                    pkm.RefreshChecksum();
                    MessageBox.Show($"过啦！");
                    Editor.PopulateFields(pkm, false);
                    SAV.ReloadSlots();
                    break;
                }
                seed = Overworld8RNG.Next(seed);
            }
        }
        private void Roaming8b_Click(object sender, EventArgs e)
        {
            var seed = Util.Rand32();
            while (true)
            {
                var pkm = Roaming8bRNG.GenPkm(Editor.Data, seed, Editor.Data.TID, Editor.Data.SID);

                if (GetShinyXor(pkm.PID, pkm.TID, pkm.SID) < 16)
                {
                    pkm.RefreshChecksum();
                    MessageBox.Show($"过啦！{seed}");
                    Editor.PopulateFields(pkm, false);
                    SAV.ReloadSlots();
                    break;
                }
                seed = Roaming8bRNG.Next(seed);
            }
        }
        private static uint GetShinyXor(uint pid, int TID, int SID)
        {
            return ((uint)(TID ^ SID) ^ ((pid >> 16) ^ (pid & 0xFFFF)));
        }
    }
}