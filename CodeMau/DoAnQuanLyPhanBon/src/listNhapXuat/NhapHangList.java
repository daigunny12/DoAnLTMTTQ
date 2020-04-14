
package listNhapXuat;
import java.util.List;
import Object.HangHoaObj;
import java.io.File;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;

public class NhapHangList {
    public List<HangHoaObj> getList (){
       List<HangHoaObj> list = new ArrayList<HangHoaObj>();
        try (Scanner sc = new Scanner(new File("NhapHang.TXT"))){
            while(sc.hasNext()){
                HangHoaObj hangHoaObj = new HangHoaObj();
                hangHoaObj.setMaHH(Integer.parseInt(sc.nextLine()));
                hangHoaObj.setTeHH(sc.nextLine());
                hangHoaObj.setDonViTinh(sc.nextLine());
                hangHoaObj.setSl(Integer.parseInt(sc.nextLine()));               
                hangHoaObj.setGiaBan(Float.parseFloat( sc.nextLine()));
                hangHoaObj.setGiaMua(Float.parseFloat( sc.nextLine()));
              
                list.add(hangHoaObj);
            }
        } catch (Exception e) {
            e.printStackTrace();
        } 
       return list;
    }
    
    public List<HangHoaObj> getDesiredList(List<HangHoaObj> itemList){
        List<HangHoaObj> tempList  = new ArrayList<HangHoaObj>();
        Collections.sort(itemList ,new Comparator<HangHoaObj>(){
            @Override public int compare(HangHoaObj p1 , HangHoaObj p2){
                return p1.getMaHH() - p2.getMaHH();
            }
        });
        int MaHH = 0;
        String TenHH = null;
        String DVT = null;
        float GiaBan = 0;
        float CK = 0;
        int SL = 0;
        HangHoaObj hangHoaObj = null;
        
        for(int i =0 ; i < itemList.size(); i++){
           int a = itemList.get(i).getMaHH();
            if (MaHH == 0 || MaHH == a){
                SL = SL + itemList.get(i).getSl();
                DVT = itemList.get(i).getDonViTinh();
                GiaBan = itemList.get(i).getGiaBan();
                TenHH = itemList.get(i).getTeHH();
                CK = itemList.get(i).getGiaMua();
            }else{
                hangHoaObj = new HangHoaObj(TenHH, DVT, GiaBan, SL, MaHH ,CK);
                if(tempList.contains(hangHoaObj)){
                    tempList.remove(hangHoaObj);
                }
                tempList.add(hangHoaObj);
                SL = 0;
                SL = SL + itemList.get(i).getSl();
            }
            
            MaHH = itemList.get(i).getMaHH();
                DVT = itemList.get(i).getDonViTinh();
                GiaBan = itemList.get(i).getGiaBan();
                TenHH = itemList.get(i).getTeHH();
                CK = itemList.get(i).getGiaMua();
            
            if(i == itemList.size() -1){
                hangHoaObj = new HangHoaObj(TenHH, DVT, GiaBan, SL, MaHH , CK);
                tempList.add(hangHoaObj);
            }
        }       
                
        return tempList;
    }
}
