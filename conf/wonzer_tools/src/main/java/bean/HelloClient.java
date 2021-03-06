package bean;

import java.util.List;
import annotation.ListDesc;
public class HelloClient{
	private int id; 

	private int name; 

	private int count; 

	private EItemQuality test_enum; 

	@ListDesc("EItemQuality")
	private List<EItemQuality> test_list_enum; 

	private Person test_struct_enum; 

	public int getId(){
		return id;
	}

	public void setId(int id){
		this.id = id;
	}

	public int getName(){
		return name;
	}

	public void setName(int name){
		this.name = name;
	}

	public int getCount(){
		return count;
	}

	public void setCount(int count){
		this.count = count;
	}

	public EItemQuality getTest_enum(){
		return test_enum;
	}

	public void setTest_enum(EItemQuality test_enum){
		this.test_enum = test_enum;
	}

	public List<EItemQuality> getTest_list_enum(){
		return test_list_enum;
	}

	public void setTest_list_enum(List<EItemQuality> test_list_enum){
		this.test_list_enum = test_list_enum;
	}

	public Person getTest_struct_enum(){
		return test_struct_enum;
	}

	public void setTest_struct_enum(Person test_struct_enum){
		this.test_struct_enum = test_struct_enum;
	}

	@Override
	public String toString(){
		StringBuilder builder = new StringBuilder();
		builder.append("id");
		builder.append(":");
		builder.append(id);
		builder.append(",");
		builder.append("name");
		builder.append(":");
		builder.append(name);
		builder.append(",");
		builder.append("count");
		builder.append(":");
		builder.append(count);
		builder.append(",");
		builder.append("test_enum");
		builder.append(":");
		builder.append(test_enum);
		builder.append(",");
		builder.append("test_list_enum");
		builder.append(":");
		builder.append(test_list_enum);
		builder.append(",");
		builder.append("test_struct_enum");
		builder.append(":");
		builder.append(test_struct_enum);
		return builder.toString();
	}
}