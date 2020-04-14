package Controller.QuanLy;

import Model.QuanLyHangHoaMod;
import Service.HangHoaService;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;
import java.util.List;
import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Font;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.RowFilter;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.table.DefaultTableModel;
import Service.HangHoaServiceImpl;
import java.awt.Color;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import view.Menu.QuanLyView.JFame.HangHoaJFame;
import Object.HangHoaObj;
import RendenrerInJTable.AlignRenderer;
import RendenrerInJTable.CurrencyRenderer;
import java.io.File;
import java.io.FileNotFoundException;
import org.apache.poi.ss.usermodel.Cell;
import javax.swing.JFrame;
import javax.swing.SwingUtilities;
import javax.swing.table.TableCellRenderer;
import org.apache.poi.ss.usermodel.CellType;
import org.apache.poi.xssf.usermodel.XSSFRow;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import view.Menu.QuanLyView.HangHoaJPanel;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class QuanLyHangHoaController {

    private JPanel pnView;
    private JButton btnAdd;
    private JTextField txtSearch;
    private JButton btnXuatFile;

    private HangHoaService hangHoaService = null;

    private String[] listColumn = {"STT", "Mã sp", "Tên sản phẩm", "Đơn vị tính", "Giá bán", "Giá mua", "SL", "Ghi chú"};

    private TableRowSorter<TableModel> rowSorter = null;

    public TableCellRenderer centerAlight = new AlignRenderer();

    public TableCellRenderer centerAlight2 = new CurrencyRenderer();

    private JFrame hangHoaJFameThem;
    private JFrame hangHoaJFameSua;

    public QuanLyHangHoaController(JPanel pnView, JButton btnAdd, JTextField txtSearch, JButton btnXuatFile) {
        this.pnView = pnView;
        this.btnAdd = btnAdd;
        this.txtSearch = txtSearch;
        this.btnXuatFile = btnXuatFile;

        this.hangHoaService = new HangHoaServiceImpl();
    }

    public void setDateToTable() {
        List<HangHoaObj> listItem = hangHoaService.getList();

        DefaultTableModel model = new QuanLyHangHoaMod().setTableHangHoa(listItem, listColumn);
        JTable table = new JTable(model);

        rowSorter = new TableRowSorter<>(table.getModel());
        table.setRowSorter(rowSorter);

        txtSearch.getDocument().addDocumentListener(new DocumentListener() {
            @Override
            public void insertUpdate(DocumentEvent e) {
                String text = txtSearch.getText();
                if (text.trim().length() == 0) {
                    rowSorter.setRowFilter(null);
                } else {
                    rowSorter.setRowFilter(RowFilter.regexFilter("(?i)" + text));
                }
            }

            @Override
            public void removeUpdate(DocumentEvent e) {
                String text = txtSearch.getText();
                if (text.trim().length() == 0) {
                    rowSorter.setRowFilter(null);
                } else {
                    rowSorter.setRowFilter(RowFilter.regexFilter("(?i)" + text));
                }
            }

            @Override
            public void changedUpdate(DocumentEvent e) {
            }
        });

        table.addMouseMotionListener(new MouseAdapter() {

            @Override
            public void mouseMoved(MouseEvent e) {
                JTable tbl = (JTable) e.getSource();
                AlignRenderer.currentRow = tbl.rowAtPoint(e.getPoint());
                CurrencyRenderer.currentRow = tbl.rowAtPoint(e.getPoint());
                tbl.repaint();
            }
        });

        table.addMouseListener(new MouseAdapter() {

            @Override
            public void mouseClicked(MouseEvent e) {

                if (e.getClickCount() == 2 && table.getSelectedRow() != -1) {
                    
                    
                    
                    DefaultTableModel model = (DefaultTableModel) table.getModel();
                    int selectedRowIndex = table.getSelectedRow();
                    selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);

                    HangHoaObj hangHoaObj = new HangHoaObj();
                    hangHoaObj.setMaHH((int) model.getValueAt(selectedRowIndex, 1));
                    hangHoaObj.setTeHH(model.getValueAt(selectedRowIndex, 2).toString());
                    hangHoaObj.setDonViTinh(model.getValueAt(selectedRowIndex, 3).toString());
                    hangHoaObj.setGiaBan((int) model.getValueAt(selectedRowIndex, 4));
                    hangHoaObj.setGiaMua((int) model.getValueAt(selectedRowIndex, 5));
                    hangHoaObj.setSl((int) model.getValueAt(selectedRowIndex, 6));
                    hangHoaObj.setGhiChu(model.getValueAt(selectedRowIndex, 7).toString());

                    if (hangHoaJFameSua != null) {
                        hangHoaJFameSua.dispose();
                        hangHoaJFameSua = new HangHoaJFame(hangHoaObj, HangHoaJPanel.it);
                        hangHoaJFameSua.setTitle("Thông tin nhà cung cấp");
                        hangHoaJFameSua.setResizable(false);
                        hangHoaJFameSua.setVisible(true);
                        hangHoaJFameSua.setLocationRelativeTo(null);
                    } else {
                        hangHoaJFameSua = new HangHoaJFame(hangHoaObj, HangHoaJPanel.it);
                        hangHoaJFameSua.setTitle("Thông tin nhà cung cấp");
                        hangHoaJFameSua.setResizable(false);
                        hangHoaJFameSua.setVisible(true);
                        hangHoaJFameSua.setLocationRelativeTo(null);
                    }
                }

                if (SwingUtilities.isRightMouseButton(e) && table.getSelectedRow() != -1) {
                    
                    int dialogResult = JOptionPane.showConfirmDialog (null, "Bạn có muốn xóa không ","Warning",JOptionPane.YES_NO_OPTION);
                    if(dialogResult ==0){
                    DefaultTableModel model = (DefaultTableModel) table.getModel();
                    int selectedRowIndex = table.getSelectedRow();
                    selectedRowIndex = table.convertRowIndexToModel(selectedRowIndex);

                    int MaNV = (int) model.getValueAt(selectedRowIndex, 1);
                    hangHoaService.Delete(MaNV);
                    setDateToTable();

                }
                }
            }

        });

        for (int i = 0; i < 8; i++) {
            if (i == 4 || i == 5) {
                table.getColumnModel().getColumn(i).setCellRenderer(centerAlight2);
            } else {
                table.getColumnModel().getColumn(i).setCellRenderer(centerAlight);
            }
        }

        table.getColumnModel().getColumn(0).setMinWidth(60);
        table.getColumnModel().getColumn(0).setMaxWidth(30);
        table.getColumnModel().getColumn(0).setPreferredWidth(60);

        table.getColumnModel().getColumn(1).setMinWidth(0);
        table.getColumnModel().getColumn(1).setMaxWidth(0);
        table.getColumnModel().getColumn(1).setPreferredWidth(0);

        table.getTableHeader().setBackground(new Color(102, 255, 255));
        table.getTableHeader().setFont(new Font("Arial", Font.BOLD, 18));
        table.getTableHeader().setPreferredSize(new Dimension(100, 50));
        table.setRowHeight(50);
        table.validate();
        table.repaint();

        JScrollPane scrollPane = new JScrollPane();
        scrollPane.getViewport().add(table);
        scrollPane.setPreferredSize(new Dimension(1300, 400));

        pnView.removeAll();
        pnView.setLayout(new BorderLayout());
        pnView.add(scrollPane);
        pnView.validate();
        pnView.repaint();
    }

    public void setEvent() {
        btnAdd.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (hangHoaJFameThem != null) {
                    hangHoaJFameThem.dispose();
                    hangHoaJFameThem = new HangHoaJFame(new HangHoaObj(), HangHoaJPanel.it);
                    hangHoaJFameThem.setTitle("Thông tin hang hóa");
                    hangHoaJFameThem.setResizable(false);
                    hangHoaJFameThem.setVisible(true);
                    hangHoaJFameThem.setLocationRelativeTo(null);
                } else {
                    hangHoaJFameThem = new HangHoaJFame(new HangHoaObj(), HangHoaJPanel.it);
                    hangHoaJFameThem.setTitle("Thông tin hang hóa");
                    hangHoaJFameThem.setResizable(false);
                    hangHoaJFameThem.setVisible(true);
                    hangHoaJFameThem.setLocationRelativeTo(null);
                }

            }

            @Override
            public void mouseEntered(MouseEvent e) {

                btnAdd.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnAdd.setBackground(new Color(0, 153, 0));
            }

        });

        btnXuatFile.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                XSSFWorkbook workbook = new XSSFWorkbook();
                XSSFSheet sheet = workbook.createSheet("Sản phẩm");

                XSSFRow row = null;
                Cell cell = null;
                row = sheet.createRow(3);

                cell = row.createCell(0, CellType.STRING);
                cell.setCellValue("STT");

                cell = row.createCell(1, CellType.STRING);
                cell.setCellValue("Mã sản phẩm");

                cell = row.createCell(2, CellType.STRING);
                cell.setCellValue("Tên sản phẩm");

                cell = row.createCell(3, CellType.STRING);
                cell.setCellValue("Đơn vị tính");

                cell = row.createCell(4, CellType.STRING);
                cell.setCellValue("Giá bán");

                cell = row.createCell(5, CellType.STRING);
                cell.setCellValue("Giá Mua");

                cell = row.createCell(6, CellType.STRING);
                cell.setCellValue("Số lượng");

                cell = row.createCell(7, CellType.STRING);
                cell.setCellValue("Ghi chú");

                List<HangHoaObj> listItem = hangHoaService.getList();

                if (listItem != null) {
                    FileOutputStream fis = null;
                    try {
                        for (int i = 0; i < listItem.size(); i++) {
                            HangHoaObj hangHoaObj = listItem.get(i);

                            row = sheet.createRow(4 + i);

                            cell = row.createCell(0, CellType.NUMERIC);
                            cell.setCellValue(i + 1);

                            cell = row.createCell(1, CellType.STRING);
                            cell.setCellValue(hangHoaObj.getMaHH());

                            cell = row.createCell(2, CellType.STRING);
                            cell.setCellValue(hangHoaObj.getTeHH());

                            cell = row.createCell(3, CellType.STRING);
                            cell.setCellValue(hangHoaObj.getDonViTinh());

                            cell = row.createCell(4, CellType.STRING);
                            cell.setCellValue(hangHoaObj.getGiaBan());

                            cell = row.createCell(5, CellType.STRING);
                            cell.setCellValue(hangHoaObj.getGiaMua());

                            cell = row.createCell(6, CellType.STRING);
                            cell.setCellValue(hangHoaObj.getSl());

                            cell = row.createCell(7, CellType.STRING);
                            cell.setCellValue(hangHoaObj.getGhiChu());

                        }
                        File f = new File("D:/Hang_Hoa.xlsx");
                        fis = new FileOutputStream(f);
                        workbook.write(fis);
                        fis.close();
                    } catch (Exception ex) {
                        ex.printStackTrace();
                    }
                }
                JOptionPane.showMessageDialog(null, "Tạo file Thanh công");
            }

            @Override
            public void mouseEntered(MouseEvent e) {

                btnXuatFile.setBackground(new Color(0, 153, 255));
            }

            @Override
            public void mouseExited(MouseEvent e) {
                btnXuatFile.setBackground(new Color(0, 153, 0));
            }
        });

    }
}
