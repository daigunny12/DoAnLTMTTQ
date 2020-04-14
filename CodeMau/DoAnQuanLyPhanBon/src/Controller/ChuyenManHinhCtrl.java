
package Controller;

import view.Menu.TrangChuJPanel;
import view.Menu.ThongKeJPanel;
import view.Menu.QuanLyJPanel;
import view.Menu.NhapHangJPanel;
import view.Menu.HeThongJPanel;
import view.Menu.BanHangJPanel;
import java.awt.BorderLayout;
import java.awt.Color;
import java.util.List;
import javax.swing.JLabel;
import javax.swing.JPanel;
import Object.DanhMucObj;
import Object.TaiKhoanObj;
import java.awt.Font;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;



public class ChuyenManHinhCtrl {
    private TaiKhoanObj taiKhoanObj = null;
    private JPanel pnRoot;
    private String kindSelected = "";
    private List<DanhMucObj> listItem =null;

    public ChuyenManHinhCtrl(JPanel pnRoot) {
        this.pnRoot = pnRoot;
    }
    
    public void setView(JPanel pnItem, JLabel lblItem){
        kindSelected = "TrangChu";
        pnItem.setBackground(new Color(0,153,0));
        lblItem.setBackground(new Color(0,153,0));
        lblItem.setFont( new Font("Arial", Font.BOLD, 20));
        
        pnRoot.removeAll();
        pnRoot.setLayout(new BorderLayout());
        pnRoot.add(new TrangChuJPanel());
        pnRoot.validate();
        pnRoot.repaint();
    }
    
    
    public void setEvent(List<DanhMucObj> listItem, TaiKhoanObj taiKhoanObj){
        this.listItem = listItem;
        this.taiKhoanObj = taiKhoanObj;
        for(DanhMucObj item: listItem){
            item.getLbl().addMouseListener(new lableEvent(item.getKind(), item.getPn(), item.getLbl()));
        }
    }

 
    
    class lableEvent implements MouseListener{

        private  JPanel node;
        
        private  String kind;     
        private JPanel pnItem;
        private JLabel lblItem;

        public lableEvent(String kind, JPanel pnItem, JLabel lblItem) {
            this.kind = kind;
            this.pnItem = pnItem;
            this.lblItem = lblItem;
        }

        @Override
        public void mouseClicked(MouseEvent e) {
            switch(kind){
                case "TrangChu":
                    node = new TrangChuJPanel();
                    break;
                case "HeThong":
                    node = new HeThongJPanel();
                    break;
                case "QuanLy":
                    node = new QuanLyJPanel();
                    break;
                case "NhapHang":
                    node = new NhapHangJPanel(taiKhoanObj);
                    break;
                case "BanHang":
                    node = new BanHangJPanel(taiKhoanObj);
                    break;
                case "ThongKe":
                    node = new ThongKeJPanel();
                    break;
                default:
                    node = new TrangChuJPanel();
                    break;
            }
            pnRoot.removeAll();
            pnRoot.setLayout(new BorderLayout());
            pnRoot.add(node);
            pnRoot.validate();
            pnRoot.repaint();
            setChangeBackgroud(kind);
         }

        @Override
        public void mousePressed(MouseEvent e) {
            kindSelected = kind;
            pnItem.setBackground(new Color(0,153,0));
            lblItem.setBackground(new Color(0,153,0));
         }

        @Override
        public void mouseReleased(MouseEvent e) {
        }

        @Override
        public void mouseEntered(MouseEvent e) {
            pnItem.setBackground(new Color(0,153,0));
            lblItem.setBackground(new Color(0,153,0));
         }

        @Override
        public void mouseExited(MouseEvent e) {
            if(!kindSelected.equalsIgnoreCase(kind)){
            pnItem.setBackground(new Color(102,0,255));
            lblItem.setBackground(new Color(102,0,255));
            }
         }   
    }
    private void setChangeBackgroud(String kind){
        for(DanhMucObj item: listItem){
            if(item.getKind().equalsIgnoreCase(kind)){
                item.getPn().setBackground(new Color(0,153,0));
                item.getLbl().setBackground(new Color(0,153,0));
            }
            else{
                item.getPn().setBackground(new Color(102,0,255));
                item.getLbl().setBackground(new Color(102,0,255));
            }
        }
    }
}

