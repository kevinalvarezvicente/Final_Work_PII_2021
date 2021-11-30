using src.Library.Class.Persistence.Lists;

namespace src.Library.Class.LoadList
{
    public class LoadList{
        public void LoadAllLists(){
            List_UnsubscribeUser.Instance.LoadList();
        }
    }
}