using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Model> _EmployeeDetails;
        public ObservableCollection<Model> EmployeeDetails
        {
            get { return _EmployeeDetails; }
            set
            {
                _EmployeeDetails = value;
                OnPropertyChanged("EmployeeDetails");
            }
        }

        private ObservableCollection<int> comboBoxItemSource = new ObservableCollection<int>();
        public ObservableCollection<int> ComboBoxItemSource
        {
            get { return comboBoxItemSource; }
            set
            {
                comboBoxItemSource = value;
                OnPropertyChanged("ComboBoxItemSource");
            }
        }
        public ViewModel()
        {
            GetStudentsDetails();
            GetComboBoxItemSource();
        }
        private void GetStudentsDetails()
        {
            EmployeeDetails = new ObservableCollection<Model>();
            EmployeeDetails.Add(new Model() { EmployeeId = 1, EmployeeName = "John", City = "America", MailId = "john1@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 2, EmployeeName = "Sam", City = "America", MailId = "sam2@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 3, EmployeeName = "Swathi", City = "France", MailId = "swathi3@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 4, EmployeeName = "Guhan", City = "America", MailId = "guhan4@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 5, EmployeeName = "Monisha", City = "Italy", MailId = "monisha5@gmail.com"});
            EmployeeDetails.Add(new Model() { EmployeeId = 6, EmployeeName = "Ram", City = "France", MailId = "ram6@gmail.com"});
            EmployeeDetails.Add(new Model() { EmployeeId = 7, EmployeeName = "Sridhar", City = "America", MailId = "Sridhar7@gmail.com"});
            EmployeeDetails.Add(new Model() { EmployeeId = 8, EmployeeName = "Mano", City = "America", MailId = "Mano8@gmail.com"});
            EmployeeDetails.Add(new Model() { EmployeeId = 9, EmployeeName = "Hema", City = "Italy", MailId = "hema9@gmail.com"});
            EmployeeDetails.Add(new Model() { EmployeeId = 10, EmployeeName = "Kasthuri", City = "America", MailId = "kasthuri10@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 11, EmployeeName = "Jagan", City = "Italy", MailId = "jagan11@gmail.com"});
            EmployeeDetails.Add(new Model() { EmployeeId = 12, EmployeeName = "Gowtham", City = "France", MailId = "gowtham12@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 13, EmployeeName = "Kalpana", City = "America", MailId = "kalpana13@gmail.com"});
            EmployeeDetails.Add(new Model() { EmployeeId = 14, EmployeeName = "Jeeva", City = "Italy", MailId = "jeeva14@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 15, EmployeeName = "Samuel", City = "France", MailId = "samuel15@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 16, EmployeeName = "Riya", City = "America", MailId = "riya16@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 17, EmployeeName = "Pavithra", City = "Italy", MailId = "pavithra17@gmail.com" });
            EmployeeDetails.Add(new Model() { EmployeeId = 18, EmployeeName = "Kumar", City = "France", MailId = "kumar18@gmail.com" });
        }
        private void GetComboBoxItemSource()
        {
            foreach (var student in EmployeeDetails)
            {
                comboBoxItemSource.Add(student.EmployeeId);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }       
    }
}
            
        
     

