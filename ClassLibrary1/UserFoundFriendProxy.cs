using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using System.Device;
using System.Device.Location;

namespace FacebookApp {
    namespace Logic
    {
        public class UserFoundFriendProxy
        {
            private const int k_YearIndex = 2;
            private const char k_BirthdaySign = '/';
            private readonly User r_FacebookUser;

            public User FacebookUser
            {
                get
                {
                    return r_FacebookUser;
                }
            }

            public int UserAge { get; private set; }

            public string Link
            {
                get
                {
                    return r_FacebookUser.Link;
                }
                set
                {
                    r_FacebookUser.Link = value;
                }
            }

            public FacebookObjectCollection<Post> Posts
            {
                get
                {
                    return r_FacebookUser.Posts;
                }
            }

            public String PictureLargeURL
            {
                get
                {
                    return r_FacebookUser.PictureLargeURL;
                }
            }

            public City Location
            {
                get
                {
                    return r_FacebookUser.Location;
                }
            }

            public string CommonStr { get; set; }

            public string DistanceBetweenUserAndFoundFriendUser { get; private set; }

            public UserFoundFriendProxy(User i_User)
            {
                if (i_User is null)
                {
                    throw new ProgrammerMisuseException("Null reference", "User");
                }
                r_FacebookUser = i_User;
                CommonStr = "";
                calculateUserAge();
                calculateDistanceBetweenUserAndFriend();
            }

            private void calculateDistanceBetweenUserAndFriend()
            {
                GeoCoordinateWatcher userLoggedInGeoCoordinate = new GeoCoordinateWatcher(new GeoPositionAccuracy());
                GeoCoordinate friendGeoCoordinate = new GeoCoordinate();

                if (FacebookUser.Location.Location != null)
                {
                    friendGeoCoordinate.Longitude = r_FacebookUser.Location.Location.Longitude.Value;
                    friendGeoCoordinate.Latitude = r_FacebookUser.Location.Location.Latitude.Value;
                    DistanceBetweenUserAndFoundFriendUser = userLoggedInGeoCoordinate.Position.Location.GetDistanceTo(friendGeoCoordinate).ToString();
                }
                else
                {
                    DistanceBetweenUserAndFoundFriendUser = "Can't calculate the distance.";
                }
            }

            private void calculateUserAge()
            {
                string[] birthDay = r_FacebookUser.Birthday.Split(k_BirthdaySign);
                int userYearOfBorn = 0, currentYear = DateTime.Now.Year;

                if (int.TryParse(birthDay[k_YearIndex], out userYearOfBorn))
                {
                    UserAge = currentYear - userYearOfBorn;
                }
                else
                {
                    throw new ArgumentException("Invalid birthday format.");
                }
            }

            public override string ToString()
            {
                return string.Format(
                    @"{0}
Birthday: {1}
Gender: {2} 
Age: {3}
City: {4}
Relationship Status: {5}
Distance: {6}",
                    r_FacebookUser.Name,
                    r_FacebookUser.Birthday,
                    r_FacebookUser.Gender,
                    UserAge,
                    r_FacebookUser.Location.Name,
                    r_FacebookUser.RelationshipStatus.ToString(),
                    DistanceBetweenUserAndFoundFriendUser);
            }
        }
    }
}
