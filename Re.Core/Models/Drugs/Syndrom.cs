using System.ComponentModel;

namespace Re.Core.Models;

public class Syndrom
{

    public int Id { get; set; }//ID
    [DisplayName("����")]
    public DateOnly Date { get; set; }
    [DisplayName("�����")]
    public TimeOnly Time { get; set; }
    [DisplayName("�������� ��������")]

    public string Description { get; set; }//�������� ��������
    [DisplayName("���")]

    public string VAS { get; set; }//���
    [DisplayName("������������� ��������")]

    public int ArtPresUp { get; set; }//������������� ��������
    [DisplayName("�������������� ��������")]

    public int ArtPresDown { get; set; }//�������������� ��������
    [DisplayName("�����")]

    public int Pulse { get; set; }//�����
    [DisplayName("��������� ����������")]

    public int SpO2 { get; set; }//��������� ����������
    [DisplayName("�������������")]

    public string Notes { get; set; }//�������������

    [DisplayName("�������� ������������")]

    public string Resuscitator { get; set; }//�������� ������������
    [DisplayName("����������� ������")]

    public string Peculiarity { get; set; }//����������� ������

    [DisplayName("��������� ��������")]
    public string Status { get; set; }//��������� ��������
}