using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

namespace Common
{

    #region

    public class ExtHashtable : Hashtable
    {
        public override void Add(object key, object value)
        {
            if (!Contains(key))
                base.Add(key, value);
        }
    }

    #endregion

    public static class CommonMethod
    {
        #region Controls_to_Entity

        /// <summary>
        ///     Controls_to_Entity
        /// </summary>
        /// <param name="entity">entity class</param>
        /// <param name="controls">control</param>
        /// <param name="pix">pix</param>
        public static void Controls_to_Entity(object entity, Control controls, string pix="")
        {
            Type type = entity.GetType();
            PropertyInfo[] pc = type.GetProperties();
            foreach (PropertyInfo pi in pc)
            {
                try
                {
                    string change_name = pix + pi.Name;
                    if (controls.FindControl(change_name) != null)
                    {
                        Type _PropertyType = pi.PropertyType;
                        if (_PropertyType.BaseType.Name == "Enum")
                            return;


                        if (controls.FindControl(change_name) is HtmlTextArea||controls.FindControl(change_name) is HtmlInputText || controls.FindControl(change_name) is TextBox)
                        {
                            #region
                            string str =string.Empty;
                            if(controls.FindControl(change_name) is HtmlInputText)
                            str = ((HtmlInputText)controls.FindControl(change_name)).Value.Trim();
                            else if (controls.FindControl(change_name) is HtmlTextArea)
                                str = ((HtmlTextArea)controls.FindControl(change_name)).Value.Trim();
                            else
                                str = ((TextBox)controls.FindControl(change_name)).Text.Trim();
                            if (!string.IsNullOrEmpty(str))
                            {
                                if (pi.PropertyType.IsEnum)
                                {
                                    pi.SetValue(entity, Enum.ToObject(pi.PropertyType, str), null);
                                }
                                else
                                {
                                    if (pi.PropertyType.Name == "Int32")
                                    {
                                        pi.SetValue(entity, Convert.ToInt32(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Int64")
                                    {
                                        pi.SetValue(entity, long.Parse(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Boolean")
                                    {
                                        if (str == "0")
                                        {
                                            pi.SetValue(entity, false, null);
                                        }
                                        else
                                        {
                                            pi.SetValue(entity, true, null);
                                        }
                                    }
                                    else if (pi.PropertyType.Name == "Double")
                                    {
                                        pi.SetValue(entity, Convert.ToDouble(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Decimal")
                                    {
                                        pi.SetValue(entity, Convert.ToDecimal(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "DateTime")
                                    {
                                        pi.SetValue(entity, DateTime.Parse(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Single")
                                    {
                                        pi.SetValue(entity, float.Parse(str), null);
                                    }
                                    else
                                    {
                                        pi.SetValue(entity, str, null);
                                    }
                                }
                            }

                            #endregion
                        }
                        if (controls.FindControl(change_name) is HtmlInputHidden)
                        {
                            #region

                            string str = ((HtmlInputHidden)controls.FindControl(change_name)).Value.Trim();
                            if (!string.IsNullOrEmpty(str))
                            {
                                if (pi.PropertyType.IsEnum)
                                {
                                    pi.SetValue(entity, Enum.ToObject(pi.PropertyType, str), null);
                                }
                                else
                                {
                                    if (pi.PropertyType.Name == "Int32")
                                    {
                                        pi.SetValue(entity, Convert.ToInt32(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Int64")
                                    {
                                        pi.SetValue(entity, long.Parse(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Boolean")
                                    {
                                        if (str == "0")
                                        {
                                            pi.SetValue(entity, false, null);
                                        }
                                        else
                                        {
                                            pi.SetValue(entity, true, null);
                                        }
                                    }
                                    else if (pi.PropertyType.Name == "Double")
                                    {
                                        pi.SetValue(entity, Convert.ToDouble(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "DateTime")
                                    {
                                        pi.SetValue(entity, DateTime.Parse(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Single")
                                    {
                                        pi.SetValue(entity, float.Parse(str), null);
                                    }
                                    else
                                    {
                                        pi.SetValue(entity, str, null);
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (controls.FindControl(change_name) is HtmlInputPassword)
                        {
                            #region

                            string str = (controls.FindControl(change_name) as HtmlInputPassword).Value.Trim();
                            if (!string.IsNullOrEmpty(str))
                            {
                                if (pi.PropertyType.IsEnum)
                                {
                                    pi.SetValue(entity, Enum.ToObject(pi.PropertyType, str), null);
                                }
                                else
                                {
                                    if (pi.PropertyType.Name == "Int32")
                                    {
                                        pi.SetValue(entity, Convert.ToInt32(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "Boolean")
                                    {
                                        if (str == "0")
                                        {
                                            pi.SetValue(entity, false, null);
                                        }
                                        else
                                        {
                                            pi.SetValue(entity, true, null);
                                        }
                                    }
                                    else if (pi.PropertyType.Name == "Double")
                                    {
                                        pi.SetValue(entity, Convert.ToDouble(str), null);
                                    }
                                    else if (pi.PropertyType.Name == "DateTime")
                                    {
                                        pi.SetValue(entity, DateTime.Parse(str), null);
                                    }
                                    else
                                    {
                                        pi.SetValue(entity, str, null);
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (controls.FindControl(change_name) is RadioButtonList)
                        {
                            #region

                            if ((controls.FindControl(change_name) as RadioButtonList).SelectedItem != null)
                            {
                                string str = (controls.FindControl(change_name) as RadioButtonList).SelectedItem.Value;
                                if (!string.IsNullOrEmpty(str))
                                {
                                    if (pi.PropertyType.IsEnum)
                                    {
                                        pi.SetValue(entity, Enum.ToObject(pi.PropertyType, str), null);
                                    }
                                    else
                                    {
                                        if (pi.PropertyType.Name == "Int32")
                                        {
                                            pi.SetValue(entity, Convert.ToInt32(str), null);
                                        }
                                        else if (pi.PropertyType.Name == "Int16")
                                        {
                                            pi.SetValue(entity, Convert.ToInt16(str), null);
                                        }
                                        else if (pi.PropertyType.Name == "Boolean")
                                        {
                                            if (str == "0")
                                            {
                                                pi.SetValue(entity, false, null);
                                            }
                                            else
                                            {
                                                pi.SetValue(entity, true, null);
                                            }
                                        }
                                        else
                                        {
                                            pi.SetValue(entity, str, null);
                                        }
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (controls.FindControl(change_name) is HtmlInputCheckBox)
                        {
                            #region

                            if ((controls.FindControl(change_name) as HtmlInputCheckBox).Checked)
                            {
                                if (pi.PropertyType.IsEnum)
                                {
                                    pi.SetValue(entity, true, null);
                                }
                                else
                                {
                                    try
                                    {
                                        pi.SetValue(entity, true, null);
                                    }
                                    catch
                                    {
                                        pi.SetValue(entity, 1, null);
                                    }
                                }
                            }
                            else
                            {
                                if (pi.PropertyType.IsEnum)
                                {
                                    pi.SetValue(entity, false, null);
                                }
                                else
                                {
                                    try
                                    {
                                        pi.SetValue(entity, false, null);
                                    }
                                    catch
                                    {
                                        pi.SetValue(entity, 0, null);
                                    }
                                }
                            }

                            #endregion
                        }
                        else if (controls.FindControl(change_name) is DropDownList)
                        {
                            if (((DropDownList) controls.FindControl(change_name)).SelectedItem != null)
                            {
                                #region

                                string str = (controls.FindControl(change_name) as DropDownList).SelectedItem.Value;
                                if (!string.IsNullOrEmpty(str))
                                {
                                    if (pi.PropertyType.IsEnum)
                                    {
                                        pi.SetValue(entity, Enum.ToObject(pi.PropertyType, str), null);
                                    }
                                    else
                                    {
                                        if (pi.PropertyType.Name == "Int32")
                                        {
                                            pi.SetValue(entity, Convert.ToInt32(str), null);
                                        }
                                        else if (pi.PropertyType.Name == "Boolean")
                                        {
                                            if (str == "0")
                                            {
                                                pi.SetValue(entity, false, null);
                                            }
                                            else
                                            {
                                                pi.SetValue(entity, true, null);
                                            }
                                        }
                                        else
                                        {
                                            pi.SetValue(entity, str, null);
                                        }
                                    }
                                }

                                #endregion
                            }
                        }
                        else if (controls.FindControl(change_name) is CheckBox)
                        {
                            #region

                            if ((controls.FindControl(change_name) as CheckBox).Checked)
                            {
                                if (pi.PropertyType.IsEnum)
                                {
                                    pi.SetValue(entity, true, null);
                                }
                                else
                                {
                                    pi.SetValue(entity, true, null);
                                }
                            }
                            else
                            {
                            }

                            #endregion
                        }
                    }
                }
                catch
                {
                }
            }
        }

        #endregion

        #region Entity_to_Controls

        /// <summary>
        ///     Entity_to_Controls
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="controls"></param>
        /// <param name="pix"></param>
        public static void Entity_to_Controls(object entity, Control controls, string pix="")
        {
            #region
            Type type = entity.GetType();
            PropertyInfo[] pc = type.GetProperties();
            foreach (PropertyInfo pi in pc)
            {
                try
                {
                    string change_name = pix + pi.Name;
                    if (controls.FindControl(change_name) != null)
                    {
                        Type _PropertyType = pi.PropertyType;
                        if (controls.FindControl(change_name) is HtmlInputText)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as HtmlInputText).Value = pi.GetValue(entity, null).ToString();
                            }
                            catch
                            {
                            }
                        }
                        if (controls.FindControl(change_name) is HtmlTextArea)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as HtmlTextArea).Value = pi.GetValue(entity, null).ToString();
                            }
                            catch
                            {
                            }
                        }
                        else if(controls.FindControl(change_name) is TextBox)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as TextBox).Text = pi.GetValue(entity, null).ToString();
                            }
                            catch
                            {
                            }
                        }
                        else if (controls.FindControl(change_name) is Label)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as Label).Text = pi.GetValue(entity, null).ToString();
                            }
                            catch
                            {
                            }
                        }
                        else if (controls.FindControl(change_name) is HtmlContainerControl)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as HtmlContainerControl).InnerHtml = pi.GetValue(entity, null).ToString();
                            }
                            catch
                            {
                            }
                        }
                        else if (controls.FindControl(change_name) is HtmlImage)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as HtmlImage).Src = pi.GetValue(entity, null).ToString();
                            }
                            catch
                            {
                            }
                        }
                        else if (controls.FindControl(change_name) is HtmlInputHidden)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as HtmlInputHidden).Value=pi.GetValue(entity, null).ToString();
                            }
                            catch
                            {

                            }
                        }
                        else if (controls.FindControl(change_name) is HtmlInputPassword)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as HtmlInputPassword).Attributes.Add("value", pi.GetValue(entity, null).ToString());
                            }
                            catch
                            {

                            }
                        }
                        else if (controls.FindControl(change_name) is DropDownList)
                        {
                            string value = pi.GetValue(entity, null).ToString();
                            var ddw = (controls.FindControl(change_name) as DropDownList);
                            foreach (ListItem li in ddw.Items)
                            {
                                li.Selected = li.Value.Trim() == value.Trim();
                            }
                        }
                        else if (controls.FindControl(change_name) is HtmlInputCheckBox)
                        {
                            string value = pi.GetValue(entity, null).ToString();
                            if (value == "True" || value == "1")
                            {
                                (controls.FindControl(change_name) as HtmlInputCheckBox).Checked = true;
                            }
                            else
                            {
                                (controls.FindControl(change_name) as HtmlInputCheckBox).Checked = false;
                            }
                        }
                        else if (controls.FindControl(change_name) is RadioButtonList)
                        {
                            string value = pi.GetValue(entity, null).ToString();
                            ListItemCollection lic = (controls.FindControl(change_name) as RadioButtonList).Items;
                            foreach (ListItem li in lic)
                            {
                                li.Selected = li.Value == value;
                            }
                        }
                        else if (controls.FindControl(change_name) is CheckBox)
                        {
                            try
                            {
                                (controls.FindControl(change_name) as CheckBox).Checked = bool.Parse(pi.GetValue(entity, null).ToString());
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                catch
                {
                }
            }

            #endregion
        }

        #endregion

        public static void DataSource_Entity<d, t>(d source, t e)
        {
            DataRow dr = null;
            string sourceType = string.Empty;
            Type datasource = source.GetType();
            sourceType = datasource.Name;
            if (sourceType == "DataRow")
            {
                dr = source as DataRow;
            }
            Type entityType = e.GetType();
            PropertyInfo[] _DataProperinfo = entityType.GetProperties();
            foreach (PropertyInfo item in _DataProperinfo)
            {
                try
                {
                    item.SetValue(e, Convert.ChangeType(dr[item.Name], item.PropertyType), null);
                }
                catch
                {
                    if (item.PropertyType.Name == "Boolean")
                    {
                        if (dr.Table.Columns.Contains(item.Name))
                        {
                            object obj;
                            obj = dr[item.Name];
                            if (obj != null)
                            {
                                item.SetValue(e, obj.ToString() == "1" ? true : false, null);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 仅清空文本框值
        /// </summary>
        /// <param name="Control"></param>
        public static void ClearValue(Control control)
        {
            var _list = control.Controls;
            foreach (var item in _list)
            {
                if (item is HtmlInputText)
                {
                    (item as HtmlInputText).Value = "";
                }
                else if (item is TextBox)
                {
                    (item as TextBox).Text = "";
                }
            }
        }
    }
}