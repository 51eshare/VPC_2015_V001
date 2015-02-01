using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Service
{
    public class b_tbUsedArea:B_Base<tbUsedArea>
    {
        public b_tbUsedArea()
        {

        }

        public tbUsedArea GetUserAreaByID(long id)
        {
            string _sql = @"SELECT a.ID,a.UsedName,b.cPdClass AS siPdClassId,c.sDistrict AS siDistrict,a.[description],a.phone,a.photos,d.sLoginId AS siUserId,a.Dates,a.faceImg 
                        FROM tbUsedArea AS a INNER JOIN tbProductClass AS b ON a.iPdClassId=b.iPdClassId
                        INNER JOIN tbDistrict AS c ON a.iDistrict=c.iDistrict
                        INNER JOIN tbUser AS d ON a.iUserId=d.iUserId where a.ID=@ID";
            DynamicParameter.Add("ID",id);
            return Get(_sql,DynamicParameter);
        }
    }
}
