using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_GTVL.EF;
using Lib_GTVL.CustomModel;
using System.Data.SqlClient;
using System.Data;

namespace Lib_GTVL.DAO
{
    public class ViecLamMoiNhat_Dao
    {
        GTVL_Model1 db = null; 
        public ViecLamMoiNhat_Dao()
        {
            db = new GTVL_Model1();
        }

        public List<CustomViecLamMoiNhat> ListAll_20(DoanhNghiep_TuyenDung_SearchParameter parameter , int pagenumber)
        {
            try
            {
                object[] sqlParams = {
                new SqlParameter("@tieudetuyen", SqlDbType.NVarChar,-1)
                {
                    Value = parameter.TieuDeTuyenDung
                },
                new SqlParameter("@khuvuc", SqlDbType.NVarChar,-1)
                {
                    Value = parameter.KhuVuc
                },
                new SqlParameter("@mucluong", SqlDbType.NVarChar,-1)
                {
                    Value = parameter.MucLuong
                },
                new SqlParameter("@trinhdo", SqlDbType.NVarChar,-1)
                {
                    Value = parameter.TrinhDo
                },
                new SqlParameter("@ngoaingu", SqlDbType.NVarChar,-1)
                {
                    Value = (parameter.NgoaiNgu==null?"":parameter.NgoaiNgu)
                },
                new SqlParameter("@tinhoc", SqlDbType.NVarChar,-1)
                {
                    Value = (parameter.TinHoc==null?"":parameter.TinHoc)
                },
                new SqlParameter("@gioitinh", SqlDbType.NVarChar,10)
                {
                    Value = parameter.GioiTinh
                },
                new SqlParameter("@nganhnghe", SqlDbType.NVarChar,-1)
                {
                    Value = parameter.NganhNghe34
                },
                //new SqlParameter("@tieudetuyen",parameter.TieuDeTuyenDung),
                //new SqlParameter("@khuvuc",parameter.KhuVuc),
                //new SqlParameter("@mucluong",parameter.MucLuong),
                //new SqlParameter("@trinhdo",parameter.TrinhDo),
                //new SqlParameter("@ngoaingu",parameter.NgoaiNgu),
                //new SqlParameter("@tinhoc",parameter.TinHoc),
                //new SqlParameter("@gioitinh",parameter.GioiTinh),
                //new SqlParameter("@nganhnghe",parameter.NganhNghe34),
                new SqlParameter("@PageNumber",pagenumber),
                new SqlParameter("@topselect",parameter.SelectTop)
            };
                string test = "DoanhNghiep_TuyenDung_MultiSearch " + "N'" + parameter.TieuDeTuyenDung + "'," + "N'" + parameter.KhuVuc + "'," + "N'" + parameter.MucLuong + "'," + "N'" + parameter.TrinhDo + "'," + "N'" + parameter.NgoaiNgu + "'," + "N'" + parameter.TinHoc + "'," + "N'" + parameter.GioiTinh + "'," + "N'" + parameter.NganhNghe34 + "'," + "'" + pagenumber + "'";
                var res = db.Database.SqlQuery<CustomViecLamMoiNhat>("DoanhNghiep_TuyenDung_MultiSearch @tieudetuyen, @khuvuc,@mucluong,@trinhdo,@ngoaingu,@tinhoc,@gioitinh,@nganhnghe,@PageNumber,@topselect"
                , sqlParams).ToList();

                return res;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
