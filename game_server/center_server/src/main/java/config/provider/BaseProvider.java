package config.provider;

import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import config.CoupleRoomInfoProvider;
import config.DynamicInfoProvider;
import database.DBUtil;

/**
 * Created by wangfang on 2016/9/12.
 */
public abstract class BaseProvider {

	public static String CONF_PATH = null;

	static {
		StringBuilder path = new StringBuilder(100);
		path.append(System.getProperty("user.dir"));
		path.append(File.separator);
		path.append("conf" + File.separator);
		String confPath = path.toString();
		CONF_PATH = confPath;
	}

	protected String confString;

	protected abstract void initString();

	protected static List<BaseProvider> providerList = new ArrayList<>();

	public static void init() {

		/// 当服务器重启时,玩家的登录状态没有修改,在开启服务器的时候,全部重置一下
	}

	public void reLoad() {
		doLoad();
		initString();
	}

	public String getConfString() {
		return confString;
	}

	public static void loadAll() {
	}

	public boolean loadConfig() {
		doLoad();
		initString();
		return true;
	}


	public abstract void doLoad();
}
