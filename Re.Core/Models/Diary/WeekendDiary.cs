﻿using Re.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Re.Core.Models
{
    public class WeekendDiary
    {
        public string[] Doctor { get; set; } //доктор
        public string[] DoctorTwo { get; set; } //доктор 2
        public string Patient { get; set; } //пациент
        public string Age { get; set; } //возраст
        public string Day { get; set; } //сутки
        public string OperationDay { get; set; } //после операции сутки
        public string[] Сonditions { get; set; } // состояние
        public string[] Сomplaints { get; set; } //жалобы
        public string ComplaintsAbout { get; set; } //жалобы на
        public string[] Conscience { get; set; } //сознание
        public string GcsSum { get; set; } //GCS сумма
        public string RassThis { get; set; } //RASS поле ввода
        public string[] Rass { get; set; } //RASS 
        public string Neurologist { get; set; } //Неврологический статус
        public List<string[]> IsGcs { get; set; } //GCS
        public string GcsOne { get; set; } //GCS 1
        public string GcsTwo { get; set; } //GCS 2
        public string GcsThree { get; set; } //GCS 3
        public List<string[]> Skin { get; set; } //кожные  покровы
        public string[] Breathing { get; set; } //дыхание
        public string[] Extubation { get; set; } //экстубация
        public string CddField { get; set; } //ЧДД
        public string[] InhalationO2 { get; set; } //ингаляция О2
        public string SpeedFlow { get; set; } //скорость потока
        public string[] Auscultatory { get; set; } //аускультативно
        public List<string[]> ShortnessOfBreath { get; set; } //ослабление дыхания 
        public string ShortnessOfBreathInput { get; set; } //ослабление дыхания поле ввода
        public List<string[]> Wheezes { get; set; } //хрипы
        public string[] RespiratorySupport { get; set; } //респираторная поддержка
        public List<string[]> RespiratorySupportMachine { get; set; } //респираторная поддержка аппарат
        public string Do { get; set; } //ДО
        public string Cd { get; set; } //ЧД
        public string Pdkv { get; set; } //ПДКВ
        public string Fio2 { get; set; } //FiO2
        public string Dvdox { get; set; } //Двдох
        public string Dpod { get; set; } //Дпод
        public string[] Hemodynamics { get; set; } //Гемодинамика
        public List<string[]> InotropicSupportOne { get; set; } //инотропная поддержка 1
        public string InotropicSupportOneInput { get; set; } //инотропная поддержка 1 поле
        public List<string[]> InotropicSupportTwo { get; set; } //инотропная поддержка 2
        public string InotropicSupportTwoInput { get; set; } //инотропная поддержка 2 поле
        public string Ad { get; set; } //АД
        public string Сhss { get; set; } //ЧСС
        public string Spo2 { get; set; } //ЧСС
        public string[] Stomach { get; set; } //Живот
        public string[] Pain { get; set; } //Болезненность
        public string PainAbout { get; set; } 
        public List<string[]> AbdominalBloating { get; set; } //Вздутие живота
        public string[] Peristalsis { get; set; } //Перистальтика
        public List<string[]> Tongue { get; set; } //Язык
        public string Diuresis { get; set; } //диурез
        public string[] Urine { get; set; } //Моча
        public string BodyTemperature { get; set; } //температура тела
        public List<string[]> Drainage { get; set; } //дренаж
        public string DrinageAbout { get; set; }
        public string Additionally { get; set; } //дополнительно
        public string SeverityOfCondition { get; set; }
        public string Laboratory1 { get; set; }
        public string Laboratory2 { get; set; }
        public string Laboratory3 { get; set; }
        public string Laboratory4 { get; set; }
        public string Laboratory5 { get; set; }
        public string Laboratory6 { get; set; }
        public string Recommended { get; set; } //рекомендовано
    }
}