using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Projeto_Pedido {
	public partial class FormUtil : Form {
		public FormUtil()
		{
			InitializeComponent();
		}

		private void VisibleControl(Control control, bool value)
		{
			control.Visible = value;
		}

		public List<KeyValuePair<int, string>> listaUF = new List<KeyValuePair<int, string>>()
		{
			new KeyValuePair<int, string>(0, ""),
			new KeyValuePair<int, string>(1, "AC"),
			new KeyValuePair<int, string>(2, "AL"),
			new KeyValuePair<int, string>(3, "AP"),
			new KeyValuePair<int, string>(4, "AM"),
			new KeyValuePair<int, string>(5, "BA"),
			new KeyValuePair<int, string>(6, "CE"),
			new KeyValuePair<int, string>(7, "DF"),
			new KeyValuePair<int, string>(8, "ES"),
			new KeyValuePair<int, string>(9, "GO"),
			new KeyValuePair<int, string>(10, "MA"),
			new KeyValuePair<int, string>(11, "MT"),
			new KeyValuePair<int, string>(12, "MS"),
			new KeyValuePair<int, string>(13, "MG"),
			new KeyValuePair<int, string>(14, "PA"),
			new KeyValuePair<int, string>(15, "PB"),
			new KeyValuePair<int, string>(16, "PR"),
			new KeyValuePair<int, string>(17, "PE"),
			new KeyValuePair<int, string>(18, "PI"),
			new KeyValuePair<int, string>(19, "RJ"),
			new KeyValuePair<int, string>(20, "RN"),
			new KeyValuePair<int, string>(21, "RS"),
			new KeyValuePair<int, string>(22, "RO"),
			new KeyValuePair<int, string>(23, "RR"),
			new KeyValuePair<int, string>(24, "SC"),
			new KeyValuePair<int, string>(25, "SP"),
			new KeyValuePair<int, string>(26, "SE"),
			new KeyValuePair<int, string>(27, "TO")
		};

		protected void DirtyFields<T>(Form _form, T entityType)
		{
			var instanceEntity = entityType;
			var properties = instanceEntity.GetType().GetProperties();
			object[] attributesObject;
			for (int i = 0; i < properties.Length; i++)
			{
				attributesObject = properties[i].GetCustomAttributes(false);
				if (attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute))
					continue;

				for (int j = 0; j < _form.Controls.Count; j++)
				{
					if( _form.Controls[j] is Panel)
					{
						var panel = (Panel)_form.Controls[j];
						DirtyPanel(panel, instanceEntity);
					}

					if (_form.Controls[j] is GroupBox)
					{
						var groupBox = (GroupBox)_form.Controls[j];
						DirtyGroupBox(groupBox, instanceEntity);
					}

					if (_form.Controls[j].Name.Contains(properties[i].Name))
					{
						DirtyControls(_form.Controls[j], instanceEntity, properties[i]);
					}
				}
			}   
		}

		#region Preencher as Propriedades

		private void DirtyControls<T>(Control _control, T instanceEntity, PropertyInfo property)
		{
			switch (property.PropertyType.Name)
			{
				case "String":
					DirtyControlString(_control, instanceEntity, property);
					break;

				case "Int32":
					DirtyControlInt32(_control, instanceEntity, property);
					break;

				case "Int64":
					DirtyControlInt64(_control, instanceEntity, property);
					break;

				case "Decimal":
					DirtyControlDecimal(_control, instanceEntity, property);
					break;

				case "DateTime":
					DirtyControlDateTime(_control, instanceEntity, property);
					break;

				case "byte[]":
				case "Byte[]":
					DirtyControlByteImage(_control, instanceEntity, property);
					break;
				default:
					break;
			}
		}

		private void DirtyControlString<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			if(control is TextBox)
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, ((TextBox)control).Text);

			if (control is MaskedTextBox)
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, ((MaskedTextBox)control).Text);

			if (control is Label)
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, ((Label)control).Text);
		}

		private void DirtyControlInt32<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			int value = 0;
			if (control is TextBox)
			{
				int.TryParse(((TextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}

			if (control is MaskedTextBox)
			{
				int.TryParse(((MaskedTextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}
		}

		private void DirtyControlInt64<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			Int64 value = 0;
			if (control is TextBox)
			{
				Int64.TryParse(((TextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}

			if (control is MaskedTextBox)
			{
				Int64.TryParse(((MaskedTextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}
		}

		private void DirtyControlDecimal<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			decimal value = 0;
			if (control is TextBox)
			{
				decimal.TryParse(((TextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}

			if (control is MaskedTextBox)
			{
				decimal.TryParse(((MaskedTextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}

			if (control is Label)
			{
				decimal.TryParse(((Label)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}
		}

		private void DirtyControlDateTime<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			DateTime value = DateTime.MinValue;
			if (control is TextBox)
			{
				DateTime.TryParse(((TextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}

			if (control is MaskedTextBox)
			{
				DateTime.TryParse(((MaskedTextBox)control).Text, out value);
				instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, value);
			}
		}

		private void DirtyControlByteImage<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			if (control is PictureBox)
			{
				var picture = ((PictureBox)control).Image;
				if (picture != null)
				{
					var imageByte = ImageToByte(picture, ImageFormat.Jpeg);
					instanceEntity.GetType().GetProperty(property.Name).SetValue(instanceEntity, imageByte);
				}
			}
		}

		public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				// Convert Image to byte[]
				image.Save(ms, format);
				byte[] imageBytes = ms.ToArray();
				return imageBytes;
			}
		}

		#endregion

		private void  DirtyPanel<T>(Panel _panel, T instanceEntity)
		{
			var properties = instanceEntity.GetType().GetProperties();

			for (int i = 0; i < properties.Length; i++)
			{
				for (int j = 0; j < _panel.Controls.Count; j++)
				{
					if (_panel.Controls[j] is Panel)
					{
						var panel = (Panel)_panel.Controls[j];
						DirtyPanel(panel, instanceEntity);
					}

					if (_panel.Controls[j] is GroupBox)
					{
						var groupBox = (GroupBox)_panel.Controls[j];
						DirtyGroupBox(groupBox, instanceEntity);
					}

					if (_panel.Controls[j].Name.Contains(properties[i].Name))
					{
						DirtyControls(_panel.Controls[j], instanceEntity, properties[i]);
					}
				}
			}
		}

		private void DirtyGroupBox<T>(GroupBox _group, T instanceEntity)
		{
			var properties = instanceEntity.GetType().GetProperties();

			for (int i = 0; i < properties.Length; i++)
			{
				for (int j = 0; j < _group.Controls.Count; j++)
				{
					if (_group.Controls[j] is Panel)
					{
						var panel = (Panel)_group.Controls[j];
						DirtyPanel(panel, instanceEntity);
					}

					if (_group.Controls[j] is GroupBox)
					{
						var groupBox = (GroupBox)_group.Controls[j];
						DirtyGroupBox(groupBox, instanceEntity);
					}

					if (_group.Controls[j].Name.Contains(properties[i].Name))
					{
						DirtyControls(_group.Controls[j], instanceEntity, properties[i]);
					}
				}
			}
		}
		
		//ClearFields
		protected void ClearFields(Control form)
		{
			for (int i = 0; i < form.Controls.Count; i++)
			{
				if (form.Controls[i] is TextBox)
					((TextBox)form.Controls[i]).Text = string.Empty;

				if (form.Controls[i] is MaskedTextBox)
					((MaskedTextBox)form.Controls[i]).Text = string.Empty;

				if (form.Controls[i] is ComboBox)
				{
					var combo = ((ComboBox)form.Controls[i]);
					if (combo.Items.Count > 0)
						combo.SelectedIndex = 0;
				}

				if (form.Controls[i] is RadioButton)
					((RadioButton)form.Controls[i]).Checked = false;

				if (form.Controls[i] is Panel || form.Controls[i] is GroupBox)
					ClearFields(form.Controls[i]);
			}
		}

		protected void EnableFields(Control form, bool enable)
		{
			for (int i = 0; i < form.Controls.Count; i++)
			{
				if (form.Controls[i] is TextBox)
					((TextBox)form.Controls[i]).Enabled = enable;

				if (form.Controls[i] is MaskedTextBox)
					((TextBox)form.Controls[i]).Enabled = enable;

				if (form.Controls[i] is ComboBox)
				{
					((ComboBox)form.Controls[i]).Enabled = enable;
					var combo = ((ComboBox)form.Controls[i]);
				}

				if (form.Controls[i] is RadioButton)
					((RadioButton)form.Controls[i]).Enabled = enable;

				if (form.Controls[i] is DataGridView)
					((DataGridView)form.Controls[i]).Enabled = enable;

				if (form.Controls[i] is Panel || form.Controls[i] is GroupBox)
					EnableFields(form.Controls[i], enable);
			}
		}


		protected void DirtyUF(ComboBox combo)
		{
			combo.DisplayMember = "Text";
			combo.ValueMember = "Value";

			var items = new[] {
				new { Text = " ", Value = "0" },
				new { Text = "AC", Value = "1" },
				new { Text = "AL", Value = "2" },
				new { Text = "AP", Value = "3" },
				new { Text = "AM", Value = "4" },
				new { Text = "BA", Value = "5" },
				new { Text = "CE", Value = "6" },
				new { Text = "DF", Value = "7" },
				new { Text = "ES", Value = "8" },
				new { Text = "GO", Value = "9" },
				new { Text = "MA", Value = "10" },
				new { Text = "MT", Value = "11" },
				new { Text = "MS", Value = "12" },
				new { Text = "MG", Value = "13" },
				new { Text = "PA", Value = "14" },
				new { Text = "PB", Value = "15" },
				new { Text = "PR", Value = "16" },
				new { Text = "PE", Value = "17" },
				new { Text = "PI", Value = "18" },
				new { Text = "RJ", Value = "19" },
				new { Text = "RN", Value = "20" },
				new { Text = "RS", Value = "21" },
				new { Text = "RO", Value = "22" },
				new { Text = "RR", Value = "23" },
				new { Text = "SC", Value = "24" },
				new { Text = "SP", Value = "25" },
				new { Text = "SE", Value = "26" },
				new { Text = "TO", Value = "27" }
			};

			combo.DataSource = items;
		}

		protected void FillFields<T>(Form _form, T entityType)
		{
			var instanceEntity = entityType;
			var properties = instanceEntity.GetType().GetProperties();
			object[] attributesObject;
			for (int i = 0; i < properties.Length; i++)
			{
				attributesObject = properties[i].GetCustomAttributes(false);
				if (attributesObject != null && attributesObject.Length > 0 && attributesObject.Any(x => x is NotMappedAttribute))
					continue;

				for (int j = 0; j < _form.Controls.Count; j++)
				{
					if (_form.Controls[j] is Panel)
					{
						var panel = (Panel)_form.Controls[j];
						FillFieldsPanel(panel, instanceEntity);
					}

					if (_form.Controls[j] is GroupBox)
					{
						var groupBox = (GroupBox)_form.Controls[j];
						FillFieldsGroupBox(groupBox, instanceEntity);
					}

					if (_form.Controls[j].Name.Contains(properties[i].Name))
					{
						FillFieldsControls(_form.Controls[j], instanceEntity, properties[i]);
					}
				}
			}
		}
		
		private void FillFieldsPanel<T>(Panel _panel, T instanceEntity)
		{
			var properties = instanceEntity.GetType().GetProperties();

			for (int i = 0; i < properties.Length; i++)
			{
				for (int j = 0; j < _panel.Controls.Count; j++)
				{
					if (_panel.Controls[j] is Panel)
					{
						var panel = (Panel)_panel.Controls[j];
						DirtyPanel(panel, instanceEntity);
					}

					if (_panel.Controls[j] is GroupBox)
					{
						var groupBox = (GroupBox)_panel.Controls[j];
						DirtyGroupBox(groupBox, instanceEntity);
					}

					if (_panel.Controls[j].Name.Contains(properties[i].Name))
					{
						DirtyControls(_panel.Controls[j], instanceEntity, properties[i]);
					}
				}
			}
		}

		private void FillFieldsGroupBox<T>(GroupBox _group, T instanceEntity)
		{
			var properties = instanceEntity.GetType().GetProperties();

			for (int i = 0; i < properties.Length; i++)
			{
				for (int j = 0; j < _group.Controls.Count; j++)
				{
					if (_group.Controls[j] is Panel)
					{
						var panel = (Panel)_group.Controls[j];
						DirtyPanel(panel, instanceEntity);
					}

					if (_group.Controls[j] is GroupBox)
					{
						var groupBox = (GroupBox)_group.Controls[j];
						DirtyGroupBox(groupBox, instanceEntity);
					}

					if (_group.Controls[j].Name.Contains(properties[i].Name))
					{
						DirtyControls(_group.Controls[j], instanceEntity, properties[i]);
					}
				}
			}
		}

		private void FillFieldsControls<T>(Control _control, T instanceEntity, PropertyInfo property)
		{
			switch (property.PropertyType.Name)
			{
				case "String":
				case "Int32":
				case "Int64":
					FillFieldsString(_control, instanceEntity, property);
					break;

				case "Decimal":
					FillFieldsDecimal(_control, instanceEntity, property);
					break;

				case "DateTime":
					FillFieldsDateTime(_control, instanceEntity, property);
					break;

				//case "byte[]":
				//case "Byte[]":
				//	DirtyControlByteImage(_control, instanceEntity, property);
				//	break;
				//default:
				//	break;
			}
		}

		private void FillFieldsString<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			if (control is TextBox)
				((TextBox)control).Text = property.GetValue(instanceEntity, null).ToString();

			if (control is MaskedTextBox)
				((MaskedTextBox)control).Text = property.GetValue(instanceEntity, null).ToString();
		}

		private void FillFieldsDecimal<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			if (control is TextBox)
				((TextBox)control).Text = ((Decimal)property.GetValue(instanceEntity, null)).ToString("F");

			if (control is MaskedTextBox)
				((MaskedTextBox)control).Text = ((Decimal)property.GetValue(instanceEntity, null)).ToString("F");
		}

		private void FillFieldsDateTime<T>(Control control, T instanceEntity, PropertyInfo property)
		{
			if (control is TextBox)
				((TextBox)control).Text = ((DateTime)property.GetValue(instanceEntity, null)).ToString("dd/MM/yy");

			if (control is MaskedTextBox)
				((MaskedTextBox)control).Text = ((DateTime)property.GetValue(instanceEntity, null)).ToString("dd/MM/yy");
		}

	}
}
