using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using TextileApp.Models;

namespace MedicalApp.UserControls
{
    /// <summary>
    /// Achieve AutoComplete TextBox or ComboBox
    /// </summary>
    public class AutoCompleteTextBox : ComboBox
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoCompleteTextBox"/> class.
        /// </summary>
        public AutoCompleteTextBox()
        {
            //load and apply style to the ComboBox.
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("/" + this.GetType().Assembly.GetName().Name +
                ";component/PresentationLayer/UserControls/AutoCompleteComboBoxStyle.xaml",
                 UriKind.Relative);
            this.Resources = rd;
            //disable default Text Search Function
            this.IsTextSearchEnabled = false;
            //objProductMaster = new ProductMasterM();
            
            //foreach (var item in objProductMaster.ListProductMaster)
            //{
            //    AutoCompleteTextBoxData autoCompleteTextBoxData = new AutoCompleteTextBoxData();
            //    autoCompleteTextBoxData.Text = item.ProductName + "-" + item.Packing;
            //    autoCompleteTextBoxData.Value = Convert.ToString(item.ProductCode);
            //    autoSuggestionList.Add(autoCompleteTextBoxData);
            //}
            
        }
        #region Property
        public ProductMasterM objProductMaster { get; set; }

        #endregion Property

        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(
                "AutoSuggestionList",
                typeof(ItemCollection),
                typeof(AutoCompleteTextBox),
                new PropertyMetadata(default(ItemCollection), OnItemsPropertyChanged));

        private static void OnItemsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // AutocompleteTextBox source = d as AutocompleteTextBox;
            // Do something...
        }
        /// <summary>
        /// Override OnApplyTemplate method 
        /// Get TextBox control out of Combobox control, and hook up TextChanged event.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            //get the textbox control in the ComboBox control
            TextBox textBox = this.Template.FindName("PART_EditableTextBox", this) as TextBox;
            if (textBox != null)
            {
                //disable Autoword selection of the TextBox
                textBox.AutoWordSelection = true;
                //handle TextChanged event to dynamically add Combobox items.
                textBox.TextChanged += new TextChangedEventHandler(textBox_TextChanged);
            }
        }

        //The autosuggestionlist source.
        private ObservableCollection<AutoCompleteTextBoxData> autoSuggestionList = new ObservableCollection<AutoCompleteTextBoxData>();

        /// <summary>
        /// Gets or sets the auto suggestion list.
        /// </summary>
        /// <value>The auto suggestion list.</value>
        public ObservableCollection<AutoCompleteTextBoxData> AutoSuggestionList
        {
            get { return autoSuggestionList; }
            set { autoSuggestionList = value; }
        }


        /// <summary>
        /// main logic to generate auto suggestion list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.TextChangedEventArgs"/> 
        /// instance containing the event data.</param>
        void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.AutoWordSelection = false;
            if (textBox.Text == "@")
            {
                textBox.SelectionStart = textBox.Text.Length;
            }
            // if the word in the textbox is selected, then don't change item collection
            if (textBox.Text != "")
            {
                if ((textBox.SelectionStart != 0 || textBox.Text.Length == 0))
                {
                    this.Items.Clear();
                    //add new filtered items according the current TextBox input
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        if (textBox.Text == " " || textBox.Text == "")
                        {
                            foreach (AutoCompleteTextBoxData s in this.autoSuggestionList)
                            {
                                string unboldpart = s.Text.Substring(textBox.Text.Length);
                                string boldpart = s.Text.Substring(0, textBox.Text.Length);
                                //construct AutoCompleteEntry and add to the ComboBox
                                AutoCompleteEntry entry = new AutoCompleteEntry(s.Text, boldpart, unboldpart, s.Value);
                                this.Items.Add(entry);
                            }
                            textBox.Text = "";
                        }
                        else
                        {
                            foreach (AutoCompleteTextBoxData s in this.autoSuggestionList)
                            {
                                if (s.Text.StartsWith(textBox.Text, StringComparison.InvariantCultureIgnoreCase))
                                {

                                    string unboldpart = s.Text.Substring(textBox.Text.Length);
                                    string boldpart = s.Text.Substring(0, textBox.Text.Length);
                                    //construct AutoCompleteEntry and add to the ComboBox
                                    AutoCompleteEntry entry = new AutoCompleteEntry(s.Text, boldpart, unboldpart, s.Value);
                                    this.Items.Add(entry);
                                }
                            }
                        }
                    }
                }
            }
            // open or close dropdown of the ComboBox according to whether there are items in the 
            // fitlered result.
            this.IsDropDownOpen = this.HasItems;

            //avoid auto selection
            textBox.Focus();
            textBox.SelectionStart = textBox.Text.Length;

        }
    }

    /// <summary>
    /// Extended ComboBox Item
    /// </summary>
    public class AutoCompleteEntry : ComboBoxItem
    {
        private TextBlock tbEntry;

        //text of the item
        private string text;
        private string value;

        /// <summary>
        /// Contrutor of AutoCompleteEntry class
        /// </summary>
        /// <param name="text">All the Text of the item </param>
        /// <param name="bold">The already entered part of the Text</param>
        /// <param name="unbold">The remained part of the Text</param>
        public AutoCompleteEntry(string text, string bold, string unbold, string value)
        {
            this.text = text;
            this.value = value;

            tbEntry = new TextBlock();
            //highlight the current input Text
            tbEntry.Inlines.Add(new Run
            {
                Text = bold,
                FontWeight = FontWeights.Bold,
                FontSize = 15,
                Foreground = new SolidColorBrush(Colors.Red),
            });
            
            tbEntry.Inlines.Add(new Run { Text = unbold });

            tbEntry.ToolTip = value;

            this.Content = tbEntry;
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        public string Text
        {
            get { return this.text; }
        }

        public string Value
        {
            get { return this.value; }
        }
    }
}
