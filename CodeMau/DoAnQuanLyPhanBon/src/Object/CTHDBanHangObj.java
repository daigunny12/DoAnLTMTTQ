package Object;

public class CTHDBanHangObj {
    private String   dvt;
    private int sanPham, sl,maHDBH;
    private float    donGia, tienCK, thanhTien, ck;
    private boolean tinhTrang;

    
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

    public int getSanPham() {
        return sanPham;
    }

    public void setSanPham(int sanPham) {
        this.sanPham = sanPham;
    }


    public String getDvt() {
        return dvt;
    }

    public void setDvt(String dvt) {
        this.dvt = dvt;
    }

    public int getSl() {
        return sl;
    }

    public void setSl(int sl) {
        this.sl = sl;
    }

    public float getCk() {
        return ck;
    }

    public void setCk(float ck) {
        this.ck = ck;
    }

    

    public float getDonGia() {
        return donGia;
    }

    public void setDonGia(float donGia) {
        this.donGia = donGia;
    }

    public float getTienCK() {
        return tienCK;
    }

    public void setTienCK(float tienCK) {
        this.tienCK = tienCK;
    }

    public float getThanhTien() {
        return thanhTien;
    }

    public void setThanhTien(float thanhTien) {
        this.thanhTien = thanhTien;
    }
}
