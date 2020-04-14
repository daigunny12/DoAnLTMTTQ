
package DAO;
import Object.CTHDNhapHangObj;
import Object.HoaDonNhapHangObj;

public interface NhapHangDAO {
    public int setMaHD();
    public boolean upDateCTHDBan(CTHDNhapHangObj cTHDNhapHangObj);
    public boolean upDateHoaDonBan(HoaDonNhapHangObj hoaDonBanHangObj);
    public boolean upTienNo(HoaDonNhapHangObj hoaDonNhapHangObj);
}
