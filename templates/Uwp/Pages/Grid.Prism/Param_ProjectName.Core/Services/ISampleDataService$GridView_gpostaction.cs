﻿//{**
// This code block adds the method `GetGridSampleDataAsync()` to the SampleDataService of your project.
//**}
//{[{
using System.Threading.Tasks;
//}]}
    public interface ISampleDataService
    {
//^^
//{[{

        Task<ObservableCollection<SampleOrder>> GetGridSampleDataAsync();
//}]}
    }
}