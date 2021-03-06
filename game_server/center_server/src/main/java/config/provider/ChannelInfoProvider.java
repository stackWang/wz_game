package config.provider;

import config.bean.ChannelConfig;
import database.DataQueryResult;
import util.MapObject;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * Created by Administrator on 2017/3/5.
 */
public class ChannelInfoProvider extends BaseProvider {

	private static ChannelInfoProvider instance = new ChannelInfoProvider();

	private ChannelInfoProvider() {

	}

	static {
		BaseProvider.providerList.add(instance);
	}

	public static ChannelInfoProvider getInst() {
		return instance;
	}

	private Map<Integer, Map<Integer, ChannelConfig>> channelConfigMap = new HashMap<>();

	public ChannelConfig getChannelConfig(int channelId, int packageId, boolean isReview) {
		return null;
	}


	@Override
	protected void initString() {

	}

	@Override
	public void doLoad() {
		Map<Integer, Map<Integer, ChannelConfig>> channelConfigMap = new HashMap<>();
		List<MapObject> roomList = DataQueryResult.load("conf_channel_switch", null);
		roomList.forEach(e -> {
			Map<Integer, ChannelConfig> packageMap = channelConfigMap.get(e.getInt("id"));
			if (packageMap == null) {
				packageMap = new HashMap<>();
				channelConfigMap.put(e.getInt("id"), packageMap);
			}
			packageMap.put(e.getInt("package_id"), new ChannelConfig(e));
		});
		
		this.channelConfigMap = channelConfigMap;
	}
}
