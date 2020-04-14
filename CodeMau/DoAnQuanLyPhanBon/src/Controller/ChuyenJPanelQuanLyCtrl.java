package Controller;

import Object.DanhMucObj;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.List;
import javax.swing.JLabel;
import javax.swing.JPanel;
import view.Menu.QuanLyView.HangHoaJPanel;
import view.Menu.QuanLyView.KhachHangJPanel;
import view.Menu.QuanLyView.NhaCungCapJPanel;
import view.Menu.QuanLyView.NhanVienJPanel;

public class ChuyenJPanelQuanLyCtrl {

    private JPanel pnRoot;
    private String kindSelected = "";
    private List<DanhMucObj> listItem = null;

    public ChuyenJPanelQuanLyCtrl(JPanel pnRoot) {
        this.pnRoot = pnRoot;
    }

    public void setView(JPanel pnItem, JLabel lblItem) {
        kindSelected = "HangHoa";
        pnItem.setBackground(new Color(0, 0, 255));
        lblItem.setBackground(new Color(0, 0, 255));

        pnRoot.removeAll();
        pnRoot.setLayout(new BorderLayout());
        pnRoot.add(new HangHoaJPanel());
        pnRoot.validate();
        pnRoot.repaint();
    }

    public void setEvent(List<DanhMucObj> listItem) {
        this.listItem = listItem;
        for (DanhMucObj item : listItem) {
            item.getLbl().addMouseListener(new lableEvent(item.getKind(), item.getPn(), item.getLbl()));
        }
    }

    class lableEvent implements MouseListener {

        private JPanel node;
        private String kind;
        private JPanel pnItem;
        private JLabel lblItem;

        public lableEvent(String kind, JPanel pnItem, JLabel lblItem) {
            this.kind = kind;
            this.pnItem = pnItem;
            this.lblItem = lblItem;
        }

        @Override
        public void mouseClicked(MouseEvent e) {
            switch (kind) {
                case "HangHoa":
                    node = new HangHoaJPanel();
                    break;
                case "NhanVien":
                    node = new NhanVienJPanel();
                    break;
                case "KhachHang":
                    node = new KhachHangJPanel();
                    break;
                case "NhaCungCap":
                    node = new NhaCungCapJPanel();
                    break;
                default:
                    node = new HangHoaJPanel();
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
            pnItem.setBackground(new Color(0, 0, 255));
            lblItem.setBackground(new Color(0, 0, 255));
        }

        @Override
        public void mouseReleased(MouseEvent e) {
        }

        @Override
        public void mouseEntered(MouseEvent e) {
            pnItem.setBackground(new Color(0, 0, 255));
            lblItem.setBackground(new Color(0, 0, 255));
        }

        @Override
        public void mouseExited(MouseEvent e) {
            if (!kindSelected.equalsIgnoreCase(kind)) {
                pnItem.setBackground(new Color(0, 153, 0));
                lblItem.setBackground(new Color(0, 153, 0));
            }
        }
    }

    private void setChangeBackgroud(String kind) {
        for (DanhMucObj item : listItem) {
            if (item.getKind().equalsIgnoreCase(kind)) {
                item.getPn().setBackground(new Color(0, 0, 255));
                item.getLbl().setBackground(new Color(0, 0, 255));
            } else {
                item.getPn().setBackground(new Color(0, 153, 0));
                item.getLbl().setBackground(new Color(0, 153, 0));
            }
        }
    }
}
