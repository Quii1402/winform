﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDiemSinhVienK19._1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLDSV1Entities : DbContext
    {
        public QLDSV1Entities()
            : base("name=QLDSV1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_khoa> tbl_khoa { get; set; }
        public virtual DbSet<tbl_sinhvien> tbl_sinhvien { get; set; }
    
        public virtual ObjectResult<GetAllStudent_Result> GetAllStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllStudent_Result>("GetAllStudent");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_DeleteKhoa(string makhoap)
        {
            var makhoapParameter = makhoap != null ?
                new ObjectParameter("makhoap", makhoap) :
                new ObjectParameter("makhoap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteKhoa", makhoapParameter);
        }
    
        public virtual int sp_Deletestudent(string masvp)
        {
            var masvpParameter = masvp != null ?
                new ObjectParameter("Masvp", masvp) :
                new ObjectParameter("Masvp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Deletestudent", masvpParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_GetAllkhoa_Result> sp_GetAllkhoa()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllkhoa_Result>("sp_GetAllkhoa");
        }
    
        public virtual ObjectResult<sp_GetAllStudent_Result> sp_GetAllStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllStudent_Result>("sp_GetAllStudent");
        }
    
        public virtual ObjectResult<sp_GetAllStudent1_Result> sp_GetAllStudent1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllStudent1_Result>("sp_GetAllStudent1");
        }
    
        public virtual ObjectResult<sp_GetKhoaIf_Result> sp_GetKhoaIf()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetKhoaIf_Result>("sp_GetKhoaIf");
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_InserKHOA(string makhoa, string tenkhoa)
        {
            var makhoaParameter = makhoa != null ?
                new ObjectParameter("makhoa", makhoa) :
                new ObjectParameter("makhoa", typeof(string));
    
            var tenkhoaParameter = tenkhoa != null ?
                new ObjectParameter("tenkhoa", tenkhoa) :
                new ObjectParameter("tenkhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InserKHOA", makhoaParameter, tenkhoaParameter);
        }
    
        public virtual int sp_InserSinhvien(string masvp, string hovatenp, Nullable<bool> gioitinh, Nullable<System.DateTime> ngaysinh, string lop, string makhoa, string hocky, string monhoc, string diemthilan1, string diemtrungbinh, string diemtongket, string hanhkiem, byte[] anhp)
        {
            var masvpParameter = masvp != null ?
                new ObjectParameter("Masvp", masvp) :
                new ObjectParameter("Masvp", typeof(string));
    
            var hovatenpParameter = hovatenp != null ?
                new ObjectParameter("Hovatenp", hovatenp) :
                new ObjectParameter("Hovatenp", typeof(string));
    
            var gioitinhParameter = gioitinh.HasValue ?
                new ObjectParameter("Gioitinh", gioitinh) :
                new ObjectParameter("Gioitinh", typeof(bool));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("Ngaysinh", ngaysinh) :
                new ObjectParameter("Ngaysinh", typeof(System.DateTime));
    
            var lopParameter = lop != null ?
                new ObjectParameter("Lop", lop) :
                new ObjectParameter("Lop", typeof(string));
    
            var makhoaParameter = makhoa != null ?
                new ObjectParameter("Makhoa", makhoa) :
                new ObjectParameter("Makhoa", typeof(string));
    
            var hockyParameter = hocky != null ?
                new ObjectParameter("Hocky", hocky) :
                new ObjectParameter("Hocky", typeof(string));
    
            var monhocParameter = monhoc != null ?
                new ObjectParameter("Monhoc", monhoc) :
                new ObjectParameter("Monhoc", typeof(string));
    
            var diemthilan1Parameter = diemthilan1 != null ?
                new ObjectParameter("Diemthilan1", diemthilan1) :
                new ObjectParameter("Diemthilan1", typeof(string));
    
            var diemtrungbinhParameter = diemtrungbinh != null ?
                new ObjectParameter("Diemtrungbinh", diemtrungbinh) :
                new ObjectParameter("Diemtrungbinh", typeof(string));
    
            var diemtongketParameter = diemtongket != null ?
                new ObjectParameter("Diemtongket", diemtongket) :
                new ObjectParameter("Diemtongket", typeof(string));
    
            var hanhkiemParameter = hanhkiem != null ?
                new ObjectParameter("Hanhkiem", hanhkiem) :
                new ObjectParameter("Hanhkiem", typeof(string));
    
            var anhpParameter = anhp != null ?
                new ObjectParameter("Anhp", anhp) :
                new ObjectParameter("Anhp", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InserSinhvien", masvpParameter, hovatenpParameter, gioitinhParameter, ngaysinhParameter, lopParameter, makhoaParameter, hockyParameter, monhocParameter, diemthilan1Parameter, diemtrungbinhParameter, diemtongketParameter, hanhkiemParameter, anhpParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual ObjectResult<sp_TimkiemSinhvien_Result> sp_TimkiemSinhvien(string masvp, string hovatenp, string lopp, string makhoap, string monhocp, string hanhkiemp)
        {
            var masvpParameter = masvp != null ?
                new ObjectParameter("Masvp", masvp) :
                new ObjectParameter("Masvp", typeof(string));
    
            var hovatenpParameter = hovatenp != null ?
                new ObjectParameter("Hovatenp", hovatenp) :
                new ObjectParameter("Hovatenp", typeof(string));
    
            var loppParameter = lopp != null ?
                new ObjectParameter("Lopp", lopp) :
                new ObjectParameter("Lopp", typeof(string));
    
            var makhoapParameter = makhoap != null ?
                new ObjectParameter("Makhoap", makhoap) :
                new ObjectParameter("Makhoap", typeof(string));
    
            var monhocpParameter = monhocp != null ?
                new ObjectParameter("Monhocp", monhocp) :
                new ObjectParameter("Monhocp", typeof(string));
    
            var hanhkiempParameter = hanhkiemp != null ?
                new ObjectParameter("Hanhkiemp", hanhkiemp) :
                new ObjectParameter("Hanhkiemp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TimkiemSinhvien_Result>("sp_TimkiemSinhvien", masvpParameter, hovatenpParameter, loppParameter, makhoapParameter, monhocpParameter, hanhkiempParameter);
        }
    
        public virtual ObjectResult<sp_TimkiemTenKhoa_Result> sp_TimkiemTenKhoa(string tenkhoap, string makhoap)
        {
            var tenkhoapParameter = tenkhoap != null ?
                new ObjectParameter("Tenkhoap", tenkhoap) :
                new ObjectParameter("Tenkhoap", typeof(string));
    
            var makhoapParameter = makhoap != null ?
                new ObjectParameter("Makhoap", makhoap) :
                new ObjectParameter("Makhoap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TimkiemTenKhoa_Result>("sp_TimkiemTenKhoa", tenkhoapParameter, makhoapParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int Update_Info_KHOA(string makhoa, string tenkhoa)
        {
            var makhoaParameter = makhoa != null ?
                new ObjectParameter("makhoa", makhoa) :
                new ObjectParameter("makhoa", typeof(string));
    
            var tenkhoaParameter = tenkhoa != null ?
                new ObjectParameter("tenkhoa", tenkhoa) :
                new ObjectParameter("tenkhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Info_KHOA", makhoaParameter, tenkhoaParameter);
        }
    
        public virtual int Update_Info_student1(string masv_1, string hovaten_1, Nullable<bool> gioitinh_1, Nullable<System.DateTime> ngaysinh_1, string lop_1, string makhoa_1, string hocky_1, string monhoc_1, string diemthilan1_1, string diemtrungbinh_1, string diemtongket_1, string hanhkiem_1, byte[] anh_1)
        {
            var masv_1Parameter = masv_1 != null ?
                new ObjectParameter("Masv_1", masv_1) :
                new ObjectParameter("Masv_1", typeof(string));
    
            var hovaten_1Parameter = hovaten_1 != null ?
                new ObjectParameter("Hovaten_1", hovaten_1) :
                new ObjectParameter("Hovaten_1", typeof(string));
    
            var gioitinh_1Parameter = gioitinh_1.HasValue ?
                new ObjectParameter("Gioitinh_1", gioitinh_1) :
                new ObjectParameter("Gioitinh_1", typeof(bool));
    
            var ngaysinh_1Parameter = ngaysinh_1.HasValue ?
                new ObjectParameter("Ngaysinh_1", ngaysinh_1) :
                new ObjectParameter("Ngaysinh_1", typeof(System.DateTime));
    
            var lop_1Parameter = lop_1 != null ?
                new ObjectParameter("Lop_1", lop_1) :
                new ObjectParameter("Lop_1", typeof(string));
    
            var makhoa_1Parameter = makhoa_1 != null ?
                new ObjectParameter("Makhoa_1", makhoa_1) :
                new ObjectParameter("Makhoa_1", typeof(string));
    
            var hocky_1Parameter = hocky_1 != null ?
                new ObjectParameter("Hocky_1", hocky_1) :
                new ObjectParameter("Hocky_1", typeof(string));
    
            var monhoc_1Parameter = monhoc_1 != null ?
                new ObjectParameter("Monhoc_1", monhoc_1) :
                new ObjectParameter("Monhoc_1", typeof(string));
    
            var diemthilan1_1Parameter = diemthilan1_1 != null ?
                new ObjectParameter("Diemthilan1_1", diemthilan1_1) :
                new ObjectParameter("Diemthilan1_1", typeof(string));
    
            var diemtrungbinh_1Parameter = diemtrungbinh_1 != null ?
                new ObjectParameter("Diemtrungbinh_1", diemtrungbinh_1) :
                new ObjectParameter("Diemtrungbinh_1", typeof(string));
    
            var diemtongket_1Parameter = diemtongket_1 != null ?
                new ObjectParameter("Diemtongket_1", diemtongket_1) :
                new ObjectParameter("Diemtongket_1", typeof(string));
    
            var hanhkiem_1Parameter = hanhkiem_1 != null ?
                new ObjectParameter("Hanhkiem_1", hanhkiem_1) :
                new ObjectParameter("Hanhkiem_1", typeof(string));
    
            var anh_1Parameter = anh_1 != null ?
                new ObjectParameter("Anh_1", anh_1) :
                new ObjectParameter("Anh_1", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Info_student1", masv_1Parameter, hovaten_1Parameter, gioitinh_1Parameter, ngaysinh_1Parameter, lop_1Parameter, makhoa_1Parameter, hocky_1Parameter, monhoc_1Parameter, diemthilan1_1Parameter, diemtrungbinh_1Parameter, diemtongket_1Parameter, hanhkiem_1Parameter, anh_1Parameter);
        }
    }
}
