public enum SideType {
	Top,
	Right,
	Bottom,
	Left,
	NONE
}

public enum TableCellType {
	Title,
	Item,
	Done,
	NONE
}

public enum CheatCodeButton {
	NONE,
	Up,
	Right,
	Down,
	Left,
	A,
	B
}

public enum ReplaysEnabledType {
	Off,
	OnWithoutFaceCam,
	OnWithFaceCam
}

public enum FeatureAvailability {
	GameCenterAndReplays,
	JustGameCenter,
	JustReplays,
	NeitherGameCenterNorReplays
}

public enum CurveDirection {
	Right,
	Left,
	NONE
}

public enum DirectionType {
	Up,
	Right,
	Down,
	Left,
	NONE
}

public enum DevicePerformanceType {
	Low,
	Medium,
	High,
	NONE
}

public enum ControlType {
	Keyboard,
	PS3,
	Xbox,
	Other,
	NONE
}

public enum ScreenTouchType {
	Right,
	Left,
	NONE
}

public enum UIItemType {
	Pause,
	Back,
	Settings,
	ViewReplay,
	HighScoreLabel,
	Leaderboards,
	CampaignCounter,
	NONE
}

public enum SceneType {
	None,
	TitleScreen,
	TitleScreenNew,
	Help,
	PivvotGameVoyage,
	PivvotGameExpertVoyage,
	PivvotGameEndless,
	PivvotGameEndlessExpert,
	PivvotGameRandomEndless,
	PivvotGameRandomExpertEndless,
	PivvotGameBerserk,
	DataOptions,
	EraseData,
	ResetVoyage,
	ResetExpertVoyage,
	PulsatorTest,
	HighScoresPage,
	NewHighScoreEntryPage,
	ShapeCreator,
	PathMenu,
	GameOver,
	Settings
}

public enum ComponentType {
	Sprite,
	SliceSprite,
	Label,
	Touch,
	PathFollow,
	PolygonSprite,
	Velocity,
	QuadSprite,
	RadialWipeSprite,
	NONE
}

public enum SongType {
	ExpertTheme,
	ExpertThemeReverse,
	MainTheme,
	MainThemeReverse,
	BerserkTheme,
	TitleTheme,
	NONE
}

public enum GameType {
	Voyage,
	Endless,
	RandomEndless,
	MAX,
	NONE,
	// stuff after this point doesn't relate to the normal campaign patterns
	Berserk
}

public enum VoyageType {
	Main,
	Expert,
	MAX,
	NONE
}