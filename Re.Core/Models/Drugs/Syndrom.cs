namespace Re.Core.Models;

public class Syndrom
{

    public int Id { get; set; }//ID

    public string Description { get; set; }//�������� ��������

    public string VAS { get; set; }//���

    public int ArtPresUp { get; set; }//������������� ��������

    public int ArtPresDown { get; set; }//�������������� ��������

    public int Pulse { get; set; }//�����

    public int SpO2 { get; set; }//��������� ����������

    public string Notes { get; set; }//�������������

    public string Resuscitator { get; set; }//�������� ������������

    public string Peculiarity { get; set; }//����������� ������


    public string Status { get; set; }//��������� ��������
}