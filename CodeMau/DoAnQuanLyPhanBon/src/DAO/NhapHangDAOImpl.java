package DAO;

import Object.CTHDNhapHangObj;
import Object.HoaDonNhapHangObj;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class NhapHangDAOImpl implements NhapHangDAO {

    @Override
    public int setMaHD() {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        int MaHDN = 0;
        String sql = "select MAX(MaHDN) as MaxMa  from HoaDonNhapHang";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                MaHDN = rs.getInt("MaxMa");
            }
            return MaHDN;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return MaHDN = 0;
    }

    @Override
    public boolean upDateCTHDBan(CTHDNhapHangObj CTHDNObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "insert into CTHDNhapHang(MaHDN,SanPham,SL,DonGia,CK,TinhTrang) values (?,?,?,?,?,'True')";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, CTHDNObj.getMaHDNH());
            ps.setInt(2, CTHDNObj.getSanPham());
            ps.setInt(3, CTHDNObj.getSl());
            ps.setFloat(4, CTHDNObj.getDonGia());
            ps.setFloat(5, CTHDNObj.getCk());

            return ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean upDateHoaDonBan(HoaDonNhapHangObj HDBHObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "insert into HoaDonNhapHang(MaHDN,NCC,NhanVienLap,NgayLap,TienTra,TinhTrang) values (?,?,?,?,?,'True')";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setInt(1, HDBHObj.getMaHDNH());
            ps.setInt(2, HDBHObj.getNcc());
            ps.setInt(3, HDBHObj.getNhanVienLap());
            ps.setDate(4, new Date(HDBHObj.getNgayLap().getTime()));
            ps.setFloat(5, HDBHObj.getTienTra());

            return ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    @Override
    public boolean upTienNo(HoaDonNhapHangObj HDNHObj) {
        Connection conn = KetNoiCSDL.KetNoiCSDL();
        String sql = "update NhaCungCap set SoNo = ? where MaNCC =?";
        try {
            PreparedStatement ps = conn.prepareStatement(sql);
            ps.setFloat(1, HDNHObj.getTienTra());
            ps.setInt(2, HDNHObj.getNcc());
            
            return ps.executeUpdate() >= 0;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return false;
    }

    }
