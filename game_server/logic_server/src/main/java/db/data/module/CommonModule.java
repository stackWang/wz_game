package db.data.module;

import database.DataQueryResult;
import db.data.DataStat;
import db.data.DbRecord;
import db.data.IModuleData;
import util.MapObject;
import util.MiscUtil;

import java.sql.SQLException;
import java.util.List;
import java.util.Map;

public class CommonModule implements IModuleData {

    private List<DbRecord> records = MiscUtil.newLinkedList();

    private final long char_id;
    private final String table_name;
    private final String charid_col;
    private final List<String> key_list;
    private final boolean disAbleDelete;

    public CommonModule(long char_id, String table_name, String charid_col, List<String> key_list, boolean disableDelete) {
        this.char_id = char_id;
        this.table_name = table_name;
        this.charid_col = charid_col;
        this.key_list = key_list;
        this.disAbleDelete = disableDelete;
    }

    @Override
    public void load() throws SQLException {
        Map<String, Object> where = MiscUtil.newArrayMap();
        where.put(charid_col, this.char_id);
        List<MapObject> dataList = DataQueryResult.load(table_name, where);
        for (int i = 0; i < dataList.size(); i++) {
            MapObject dataItem = dataList.get(i);
            DbRecord record = new DbRecord(dataItem);
            records.add(record);
        }
    }

    @Override
    public void save() throws SQLException {
        DbRecord.save(records, this.table_name, this.key_list);
    }

    @Override
    public void update(MapObject moduleData) {
        Object[] moduleDatas = (Object[]) moduleData.get(Long.toString(char_id));
        DbRecord.update(records, moduleDatas, this.key_list, this.disAbleDelete);
        // OK!
    }

    @Override
    public MapObject getData() {
        List<MapObject> datas = MiscUtil.newArrayList();
        for (DbRecord record : records) {
            if (record.stat != DataStat.DELETE) {
                datas.add(record.data);
            }
        }
        MapObject ret = new MapObject();
        ret.put("" + char_id, datas.toArray());
        return ret;
    }

    @Override
    public boolean checkSame(MapObject newData) {
        Object[] moduleDatas = (Object[]) newData.get(Long.toString(char_id));
        boolean ret = DbRecord.checkSameKeySet(records, moduleDatas, this.key_list);
        return ret;
    }
}

