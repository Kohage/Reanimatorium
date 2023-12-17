namespace Re.Core.Models;

public class Patient{

    public int Id { get; set; }//ID
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }

    public string FIO { get; set; }//���

    public string Adress { get; set; }//�����?

    public string Peculiarity { get; set; }//����������� ������

    public string VAS { get; set; }//���

  

    public string Notes { get; set; }//�������������

    public int ArtPresUp { get; set; }//������������� ��������

    public int ArtPresDown { get; set; }//�������������� ��������

    public int Pulse { get; set; }//�����

    public int SpO2 { get; set; }//��������� ����������


}