/*
 * Creado por SharpDevelop.
 * Usuario: ahren
 * Fecha: 23/10/2026
 * Hora: 07:34 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Multiplica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.txtNUM2 = new System.Windows.Forms.TextBox();
			this.txtNUM1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(12, 78);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(269, 64);
			this.btnMultiplicar.TabIndex = 0;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// lblNum2
			// 
			this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum2.Location = new System.Drawing.Point(49, 38);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(100, 24);
			this.lblNum2.TabIndex = 1;
			this.lblNum2.Text = "Numero 2:";
			// 
			// lblNum1
			// 
			this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum1.Location = new System.Drawing.Point(49, 11);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(100, 23);
			this.lblNum1.TabIndex = 2;
			this.lblNum1.Text = "Numero 1:";
			// 
			// txtNUM2
			// 
			this.txtNUM2.Location = new System.Drawing.Point(155, 40);
			this.txtNUM2.Name = "txtNUM2";
			this.txtNUM2.Size = new System.Drawing.Size(100, 22);
			this.txtNUM2.TabIndex = 3;
			// 
			// txtNUM1
			// 
			this.txtNUM1.Location = new System.Drawing.Point(155, 12);
			this.txtNUM1.Name = "txtNUM1";
			this.txtNUM1.Size = new System.Drawing.Size(100, 22);
			this.txtNUM1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 153);
			this.Controls.Add(this.txtNUM1);
			this.Controls.Add(this.txtNUM2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.btnMultiplicar);
			this.Name = "MainForm";
			this.Text = "Multiplica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtNUM1;
		private System.Windows.Forms.TextBox txtNUM2;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Button btnMultiplicar;
	}
}
