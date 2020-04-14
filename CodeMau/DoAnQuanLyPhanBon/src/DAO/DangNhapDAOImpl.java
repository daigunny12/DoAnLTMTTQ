
package DAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import Object.TaiKhoanObj;



public class DangNhapDAOImpl implements DangNhapDAO{

    @Override
    public TaiKhoanObj DangNhap(String tenDN, String matKhau) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "select dn.* , nv.TenNV from  DangNhap dn ,NhanVien  nv where dn.MaNV = nv.MaNV and TenDN = ? and MatKhau = ? COLLATE SQL_Latin1_General_CP1_CS_AS";
        TaiKhoanObj taiKhoanObj = null;
        try {
            PreparedStatement ps =(PreparedStatement) conn.prepareStatement(sql);
            ps.setString(1, tenDN);
            ps.setString(2, matKhau);
            
            ResultSet rs = ps.executeQuery();
            if(rs.next()){
                taiKhoanObj = new TaiKhoanObj();
                taiKhoanObj.setMaTK(rs.getInt("MaNV"));
                taiKhoanObj.setTenDN(rs.getString("TenDN"));
                taiKhoanObj.setChucVu(rs.getString("ChucVu"));
                taiKhoanObj.setTinhTrang(rs.getBoolean("TinhTrang"));
                taiKhoanObj.setTenNV(rs.getString("TenNV"));
            }
            ps.close();
            rs.close();
            return taiKhoanObj;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return null;
    }
    
}
