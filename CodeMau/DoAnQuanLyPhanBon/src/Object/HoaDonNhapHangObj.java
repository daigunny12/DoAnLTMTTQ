package Object;

import java.util.Date;

public class HoaDonNhapHangObj {
    private Date   ngayLap;
    private int maHDNH , ncc, nhanVienLap;
    private boolean tinhTrang;
    private float TienTra;

    public float getTienTra() {
        return TienTra;
    }

    public void setTienTra(float TienTra) {
        this.TienTra = TienTra;
    }
    
    

    public int getMaHDNH() {
        return maHDNH;
    }

    public void setMaHDNH(int maHDNH) {
        this.maHDNH = maHDNH;
    }

    public boolean isTinhTrang() {
        return tinhTrang;
    }

    public void setTinhTrang(boolean tinhTrang) {
        this.tinhTrang = tinhTrang;
    }

    public Date getNgayLap() {
        return ngayLap;
    }

    public void setNgayLap(Date ngayLap) {
        this.ngayLap = ngayLap;
    }

    public int getNcc() {
        return ncc;
    }

    public void setNcc(int ncc) {
        this.ncc = ncc;
    }

    public int getNhanVienLap() {
        return nhanVienLap;
    }

    public void setNhanVienLap(int nhanVienLap) {
        this.nhanVienLap = nhanVienLap;
    }

}
