
package Service;

import Object.CTHDNhapHangObj;
import Object.HoaDonNhapHangObj;


public interface NhapHangService {
    public int setMaHD();
    public boolean upDateCTHDBan(CTHDNhapHangObj cTHDNhapHangObj);
    public boolean upDateHoaDonBan(HoaDonNhapHangObj hoaDonBanHangObj);
    public boolean upTienNo(HoaDonNhapHangObj hoaDonNhapHangObj); 
}
