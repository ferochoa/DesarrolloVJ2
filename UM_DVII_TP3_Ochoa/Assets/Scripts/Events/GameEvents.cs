using UnityEngine;
using System.Collections;

public class GameEvents : MonoBehaviour {


   
	public static string ON_PLAYER_ADDED_TO_SCENE = "ON_PLAYER_ADDED_TO_SCENE";
	public static string ON_APLICATION_READY = "ON_APLICATION_READY";  
    public static string ON_PLAYER_GO_LEFT = "ON_PLAYER_GO_LEFT";
    public static string ON_PLAYER_GO_RIGHT = "ON_PLAYER_GO_RIGHT";
    public static string ON_PLAYER_GO_FOWARD = "ON_PLAYER_GO_FOWARD"; 
    public static string ON_PLAYER_GO_BACKWARD = "ON_PLAYER_GO_BACKWARD";
    public static string ON_PLAYER_JUMP = "ON_PLAYER_JUMP";
	public static string GAME_OVER = "GAME_OVER";
    public static string READY_TO_GO = "READY_TO GO";
    public static string ON_SET_POINTS = "ON_SET_POINTS";
    public static string ON_ENEMY_COLLISION = "ON_ENEMY_COLLISION";
	public static string TO_ADD_SPEED_BONUS = "TO_ADD_SPEED_BONUS";
	public static string TO_ADD_POWER_BONUS = "TO_ADD_POWER_BONUS";
	public static string TO_DECREASE_ENEMY_SPEED = "TO_DECREASE_ENEMY_SPEED";
    public static string ON_SPEED_BONUS_ADDED = "ON_SPEED_BONUS_ADDED";
	public static string ON_SPEED_BONUS_ENDED = "ON_SPEED_BONUS_ENDED";
	public static string ON_SPEED_PENALTY_ENDED = "ON_SPEED_PENALTY_ENDED";
	public static string ON_POWER_BONUS_ADDED = "ON_POWER_BONUS_ADDED";
	public static string ON_SPEED_RESTARTED = "ON_SPEED_RESTARTED";
	public static string ON_ENEMY_SPEED_RESTARTED = "ON_ENEMY_SPEED_RESTARTED";
	public static string ON_ENEMY_SPEED_DECREASED = "ON_ENEMY_SPEED_DECREASED";
	public static string SET_TIMER_FLAG = "SET_TIMER_FLAG";
	public static string ON_PLAYER_COLLISION = "ON_PLAYER_COLLISION";
	public static string ON_INVENTORY_MANIPULATION = "ON_INVENTORY_MANIPULATION";
	public static string ITEM_PICKED_UP = "ITEM_PICKED_UP";
	public static string ADD_ITEM = "ADD_ITEM";
	public static string ON_ITEM_ADDED_TO_INVENTORY = "ON_ITEM_ADDED_TO_INVENTORY";
	public static string PAINT_SLOT_ITEM_INVENTORY = "PAINT_SLOT_ITEM_INVENTORY";
	public static string ON_SELECT_ITEM_BY_KEY = "ON_SELECT_ITEM_BY_KEY";
	public static string ON_ITEM_SELECTED = "ON_ITEM_SELECTED";
	public static string USE_ITEM = "USE_ITEM";
}
