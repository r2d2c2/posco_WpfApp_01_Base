using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_04_Dessin.Models;

namespace WpfApp_04_Dessin.ViewModels
{
    public partial class TodoViewModel : ObservableObject //  partial 필수
    {
        public ObservableCollection<TodoItem> TodoItems { get; } = new();
        //읽기전용 속서으로 TodoItem 컬렉션을 초기화합니다.
        // ui와 연결될수 있는 컬랙션

        [ObservableProperty]//바인딩
        private string newTask;

        [ObservableProperty]//바인딩
        private TodoItem selectedItem;

        //추가 버튼 클릭시 실행될 커맨드(이벤트)
        [RelayCommand]
        private void AddTask()
        {
            if(!string.IsNullOrWhiteSpace(NewTask))
            {
                TodoItems.Add(new TodoItem
                {
                    Task = NewTask! //항목 추가
                    
                });
                NewTask = string.Empty;
            }
        }
        //삭제 버튼
        [RelayCommand]
        private void RemoveTask()
        {
            if (selectedItem != null)
            {
                TodoItems.Remove(selectedItem);
            }
        }
    }
}
