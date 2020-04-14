package DAO;

import Object.CTHDBanHangObj;
import Object.HoaDonBanHangObj;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Date;

public class BanHangDAOImpl implements BanHangDAO {

    @Override
    public int setMaHD() {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        int MaHDB = 0;
        String sql = "select MAX(MaHDB) as MaxMa  from HoaDonBanHang";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                MaHDB = rs.getInt("MaxMa");
            }
            return MaHDB;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return MaHDB = 0;
    }

    @Override
    public boolean upDateCTHDBan(CTHDBanHangObj CTHDBObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "insert into CTHDBanHang(MaHDB,SanPham,SL,DonGia,CK,TinhTrang) values (?,?,?,?,?,'True')";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, CTHDBObj.getMaHDBH());
            ps.setInt(2, CTHDBObj.getSanPham());
            ps.setInt(3, CTHDBObj.getSl());
            ps.setFloat(4, CTHDBObj.getDonGia());
            ps.setFloat(5, CTHDBObj.getCk());

            return ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean upDateHoaDonBan(HoaDonBanHangObj HDBanHangObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "insert into HoaDonBanHang(MaHDB,KhachHang,NhanVienLap,NgayLap,TienTra,TinhTrang) values (?,?,?,?,?,'True')";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, HDBanHangObj.getMaHDBH());
            ps.setInt(2, HDBanHangObj.getKhachHang());
            ps.setInt(3, HDBanHangObj.getNhanVienLap());
            ps.setDate(4, new Date(HDBanHangObj.getNgayLap().getTime()));
            ps.setFloat(5, HDBanHangObj.getTienTra());

            return ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean upTienNo(HoaDonBanHangObj hoaDonBanHangObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "update KhachHang set SoNo = ? where MaKH =?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setFloat(1, hoaDonBanHangObj.getTienTra());
            ps.setInt(2, hoaDonBanHangObj.getKhachHang());
            
            return ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

}
