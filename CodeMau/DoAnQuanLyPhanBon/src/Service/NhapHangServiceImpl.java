
package Service;

import Object.CTHDNhapHangObj;
import Object.HoaDonNhapHangObj;
import DAO.NhapHangDAO;
import DAO.NhapHangDAOImpl;

public class NhapHangServiceImpl implements NhapHangService{

    private NhapHangDAO nhapHangDAO = null;
    public NhapHangServiceImpl() {
        this.nhapHangDAO = new NhapHangDAOImpl();
    }

    
    
    @Override
    public int setMaHD() {
       return nhapHangDAO.setMaHD();
    }

    @Override
    public boolean upDateCTHDBan(CTHDNhapHangObj cTHDNhapHangObj) {
        return  nhapHangDAO.upDateCTHDBan(cTHDNhapHangObj);
    }

    @Override
    public boolean upDateHoaDonBan(HoaDonNhapHangObj hoaDonBanHangObj) {
        return nhapHangDAO.upDateHoaDonBan(hoaDonBanHangObj);
    }

    @Override
    public boolean upTienNo(HoaDonNhapHangObj hoaDonNhapHangObj) {
        return nhapHangDAO.upTienNo(hoaDonNhapHangObj);
    }
    
}
