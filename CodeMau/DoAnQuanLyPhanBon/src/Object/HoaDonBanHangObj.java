package Object;

import java.util.Date;

public class HoaDonBanHangObj {
    private Date   ngayLap;
    private int maHDBH , khachHang, nhanVienLap;
    private boolean tinhTrang;
    private float TienTra;

    public float getTienTra() {
        return TienTra;
    }

    public void setTienTra(float TienTra) {
        this.TienTra = TienTra;
    }

    
    public int getMaHDBH() {
        return maHDBH;
    }

    public void setMaHDBH(int maHDBH) {
        this.maHDBH = maHDBH;
    }

    public boolean isTinhTrang() {
        return tinhTrang;
    }

    public void setTinhTrang(boolean tinhTrang) {
        this.tinhTrang = tinhTrang;
    }

    public int getKhachHang() {
        return khachHang;
    }

    public void setKhachHang(int khachHang) {
        this.khachHang = khachHang;
    }

    public int getNhanVienLap() {
        return nhanVienLap;
    }

    public void setNhanVienLap(int nhanVienLap) {
        this.nhanVienLap = nhanVienLap;
    }

    public Date getNgayLap() {
        return ngayLap;
    }

    public void setNgayLap(Date ngayLap) {
        this.ngayLap = ngayLap;
    }
 
}
