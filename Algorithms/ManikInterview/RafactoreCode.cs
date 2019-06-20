using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    class RafactoreCode
    {
    }
    //class SomeClass
    //{
    //    public string externalServiceUrl = ""; //Read url from configuration/resource file

    //    public UserProfile Get_UserProfile(object userName)
    //    {
    //        var provider = new HttpProvider(externalServiceUrl); //Inject this object

    //        var response = await provider.GetAsync<User>(userName);
    //        var favorites = await provider.GetFavoritesAsync().ToList().Where(x => x.UserId == response.UserId);//Don't do ToList here, instead do it
    //        var result = Map_Response_Which_Was_Retrived_From_User__Store_To_User_Profile(response);//Giving meaningful name is good but this seems a bit lengthy.


    //        //Thread.Sleep(1000); you can remove this commented code
    //        provider.Dispose(); //Once HttpProvide is injected, disposing the object should be taken care by caller, if not, use using here

    //        foreach (var item in favorites) // We can use mapper here?
    //        {
    //            var F = new FavoriteItem();
    //            F.Title = item.ProductName;
    //            F.Id = item.Id;

    //            result.Favorites.Add(F);
    //        }
    //        return result;
    //    }

    //    private static UserProfile Map_Response_Which_Was_Retrived_From_User__Store_To_User_Profile(dynamic userInfo)
    //    {
    //        UserProfile R = new UserProfile();

    //        R.UserName = userInfo.Name;

    //        return R;
    //    }
    //}
}
