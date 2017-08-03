using PrimaProvaProgetto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaProvaProgetto.Presentation
{
    class ModifierFormPresenter
    {
        private ModifierForm _target;
        private object _toModify;

        public ModifierFormPresenter(ModifierForm target)
        {
            if (target == null)
                throw new ArgumentNullException("target");
            _target = target;
            Target.OkButton.Click += OkButton_Click;
        }

        public ModifierForm Target
        {
            get { return _target; }
        }

        public void SetEditableObject(object toModify)
        {
            _toModify = toModify;
            InitializeTarget();
        }

        private void InitializeTarget()
        {
            Target.SuspendLayout();
            Target.PropertiesPanel.Controls.Clear();
            IEnumerable<PropertyInfo> editableProperties = _toModify.GetType().GetProperties().
                Where(property => property.GetCustomAttribute<EditabileAttribute>() != null);

            foreach (PropertyInfo property in editableProperties)
                AddRow(property);
            Target.ResumeLayout(false);

            Target.OkButton.Focus();
        }

        private void AddRow(PropertyInfo property)
        {
            EditabileAttribute attribute = property.GetCustomAttribute<EditabileAttribute>();
            Label name = new Label();
            name.Text = property.Name;
            Target.PropertiesPanel.Controls.Add(name, 0, Target.PropertiesPanel.RowCount);

            Control modifier;
            if (attribute.Modifier == null)
                modifier = new StringModifier();
            else
                modifier = (Control)attribute.Modifier.GetConstructor(Type.EmptyTypes).Invoke(Type.EmptyTypes);
            modifier.Name = "_" + name.Text + "Modifier";
            modifier.Tag = property;
            Target.PropertiesPanel.Controls.Add(modifier, 1, Target.PropertiesPanel.RowCount++);
            ((IModifierControl)modifier).MyValue = property.GetGetMethod().Invoke(_toModify, null);
        }

        public void OkButton_Click(object sender, EventArgs e)
        {
            foreach(Control control in Target.PropertiesPanel.Controls)
            {
                if (! (control is Label))
                {
                    IModifierControl modifier = (IModifierControl)control;
                    PropertyInfo property = (PropertyInfo)((Control)modifier).Tag;
                    property.GetSetMethod().Invoke(_toModify, new[] { modifier.MyValue });
                }
            }
            Target.DialogResult = DialogResult.OK;
            Target.Close();
        }

    }
}
