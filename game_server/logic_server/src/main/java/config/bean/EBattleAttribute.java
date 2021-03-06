package config.bean;

public enum EBattleAttribute{
	HP(1),
	MAX_HP(2),
	ATTACK(3),
	PHYSIC_ATTACK(4),
	MAGIC_ATTACK(5),
	DEFENCE(6),
	PHYSIC_DEFENCE(7),
	MAGIC_DEFENCE(8),
	ATTACK_PERCENT(9),
	DEFENCE_PERCENT(10),
	HP_PERCENT(11),
	HIT(12),
	DODGE(13),
	BONUS(14),
	BONUS_REGISTANCE(15),
	ADD_HURT(16),
	REDUCE_HURT(17),
	PVP_ADD_HURT(18),
	PVP_REDUCE_HURT(19),
	ADD_SHU_HURT(20),
	REDUCE_SHU_HURT(21),
	ADD_WEI_HURT(22),
	REDUCE_WEI_HURT(23),
	ADD_WU_HURT(24),
	REDUCE_WU_HURT(25),
	ADD_QUN_HURT(26),
	REDUCE_QUN_HURT(27),
	HP_GROW(28),
	ATTACK_GROW(29),
	DEFENCE_GROW(30);

	EBattleAttribute(int value){
		this.value = value;
	}

	private int value;

	public int getValue(){
		return this.value;
	}

	public static EBattleAttribute getByValue(int value){
		for(EBattleAttribute type : values()){
			if(type.getValue() == value){
				return type;
			}
		}
		return null;
	}

}