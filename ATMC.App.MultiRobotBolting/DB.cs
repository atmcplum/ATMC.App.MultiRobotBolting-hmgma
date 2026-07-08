using Abeo.Controls;
using ATMC.Common;
using LotusAPI.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ATMC.App.MultiRobotBolting {
    public class DB : SqliteDatabase {
        public const string TBL_NAME = "RESULT";
        public static Dictionary<string, Color> ChartColorMap
            = new Dictionary<string, Color> {
                ["NG"] = SolarizedColorPalette.Red,
                ["OK"] = SolarizedColorPalette.Green
            };

        public enum COL {
            ID,
            DATE,
            MODEL,
            BODY_NO,
            SEQ_NO,
            RESULT, FIT, OVL,
            DX, DY, DZ, DRX, DRY, DRZ,
            OX, OY, OZ, ORX, ORY, ORZ,
            RESULT_DIR
        }

        //Prepare a list of displayable columns
        public static string[] DisplayColumns = new COL[] {
            COL.ID, COL.DATE, COL.MODEL, COL.BODY_NO,COL.SEQ_NO,
            COL.RESULT,
            COL.FIT, COL.OVL,
            COL.DX, COL.DY, COL.DZ, COL.DRX, COL.DRY, COL.DRZ,
            COL.OX, COL.OY, COL.OZ, COL.ORX, COL.ORY, COL.ORZ,
            COL.RESULT_DIR
        }.Select(x => x.ToString()).ToArray();

        public static List<ColorMap> GetColorMaps() => new List<ColorMap> {
                    new ColorMap{ ColumnName = DB.COL.RESULT.ToString(), Value = "NG", BackColor = NiceColor.Alizarin, ForeColor = NiceColor.MidnightBlue, },
                    new ColorMap{ ColumnName = DB.COL.RESULT.ToString(), Value = "OK", BackColor = NiceColor.Emerald, ForeColor = NiceColor.MidnightBlue },
                };

        public static List<FlatDataGridView.ColumnGroup> GetColumnGroups() => new List<FlatDataGridView.ColumnGroup> {
            new FlatDataGridView.ColumnGroup{ Text = "", ColumnSpan = 6, BackColor = SolarizedColor.Base1, ForeColor = SolarizedColor.Base03},
            new FlatDataGridView.ColumnGroup{ ColumnSpan = 14, BackColor = SolarizedColor.Base1, ForeColor = SolarizedColor.Base03,Text = "REGISTRATION"},
            new FlatDataGridView.ColumnGroup{ ColumnSpan = 1, BackColor = SolarizedColor.Base1, ForeColor = SolarizedColor.Base03,Text = ""},
            };
        public static List<FlatDataGridView.ColumnHeaderStyle> GetColumnHeaderStyles() => new List<FlatDataGridView.ColumnHeaderStyle> {
            new FlatDataGridView.ColumnHeaderStyle{Name=COL.RESULT.ToString(),BackColor = SolarizedColor.Base1,ForeColor = SolarizedColor.Base03, Text="RES"},
        };

        public void InitView(DBView dbview) {
            dbview.Init(this, Query, DisplayColumns,
                GetColumnGroups(),
                GetColumnHeaderStyles(),
                GetColorMaps());
        }

        public static Table MyTable { get; internal set; } = null;
        public static CommonQuery Query { get; internal set; } = null;

        public DB() : base(Global.DbFile) { }

        public override bool Connect() {
            try {
                if(base.Connect()) {
                    MyTable = new Table(TBL_NAME,
                        new Column[] {
                            new IntColumn(COL.ID,0,true,true),
                            new DatetimeColumn(COL.DATE),
                            new TextColumn(COL.MODEL,"",true),
                            new TextColumn(COL.BODY_NO),
                            new TextColumn(COL.SEQ_NO),
                            new CharColumn(COL.RESULT,"",2,true),
                            new FloatColumn(COL.FIT),
                            new FloatColumn(COL.OVL),
                            new FloatColumn(COL.DX),
                            new FloatColumn(COL.DY),
                            new FloatColumn(COL.DZ),
                            new FloatColumn(COL.DRX),
                            new FloatColumn(COL.DRY),
                            new FloatColumn(COL.DRZ),
                            new FloatColumn(COL.OX),
                            new FloatColumn(COL.OY),
                            new FloatColumn(COL.OZ),
                            new FloatColumn(COL.ORX),
                            new FloatColumn(COL.ORY),
                            new FloatColumn(COL.ORZ),

                            new TextColumn(COL.RESULT_DIR),
                        });

                    AddTable(MyTable);

                    //Prepare common query
                    Query = new CommonQuery(MyTable);
                    Query.DateColumnName = COL.DATE.ToString();
                    Query.ResultColumnName = COL.RESULT.ToString();

                    return true;
                }
            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
            return false;
        }
    }
}
