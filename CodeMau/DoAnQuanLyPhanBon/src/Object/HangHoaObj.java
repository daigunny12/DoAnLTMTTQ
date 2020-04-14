package Object;

import java.io.Serializable;

public class HangHoaObj implements Serializable{
    private String  teHH, donViTinh, ghiChu;
    private float giaBan,  giaMua;
    private int sl, maHH;
    private boolean tinhTrang;

    public HangHoaObj(String teHH, int sl, int maHH) {
        this.teHH = teHH;
        this.sl = sl;
        this.maHH = maHH;
    }
    
    

    public HangHoaObj(String teHH, String donViTinh, float giaBan, int sl, int maHH ,float giaMua) {
        this.teHH = teHH;
        this.donViTinh = donViTinh;
        this.giaBan = giaBan;
        this.sl = sl;
        this.maHH = maHH;
        this.giaMua = giaMua;
    }

    public HangHoaObj() {
    }
    

    public int getMaHH() {
        return maHH;
    }

    public void setMaHH(int maHH) {
        this.maHH = maHH;
    }

    public boolean isTinhTrang() {
        return tinhTrang;
    }

    public void setTinhTrang(boolean tinhTrang) {
        this.tinhTrang = tinhTrang;
    }
    
    
    

    public String getTeHH() {
        return teHH;
    }

    public void setTeHH(String teHH) {
        this.teHH = teHH;
    }

    public String getDonViTinh() {
        return donViTinh;
    }

    public void setDonViTinh(String donViTinh) {
        this.donViTinh = donViTinh;
    }

    public String getGhiChu() {
        return ghiChu;
    }

    public void setGhiChu(String ghiChu) {
        this.ghiChu = ghiChu;
    }

    public float getGiaBan() {
        return giaBan;
    }

    public void setGiaBan(float giaBan) {
        this.giaBan = giaBan;
    }

    public float getGiaMua() {
        return giaMua;
    }

    public void setGiaMua(float giaMua) {
        this.giaMua = giaMua;
    }

    public int getSl() {
        return sl;
    }

    public void setSl(int sl) {
        this.sl = sl;
    }
 
    
    
}
