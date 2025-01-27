﻿using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace CommunityToolkit.Maui.Markup.Sample.Views.News;

class StoryDataTemplate : DataTemplate
{
	public StoryDataTemplate() : base(CreateGrid)
	{

	}

	static Grid CreateGrid() => new()
	{
		RowSpacing = 1,

		RowDefinitions = Rows.Define(
			(Row.Title, 20),
			(Row.Description, 20),
			(Row.BottomPadding, 1)),

		Children =
		{
			new Label { LineBreakMode = LineBreakMode.TailTruncation, MaxLines = 1 }
				.Row(Row.Title)
				.Font(size: 16).DynamicResource(Label.TextColorProperty, nameof(BaseTheme.PrimaryTextColor))
				.Top().Padding(10, 0)
				.Bind(Label.TextProperty, nameof(StoryModel.Title))
				.SemanticHint("The title of the news article."),

			new Label().Row(Row.Description)
				.Font(size: 13).DynamicResource(Label.TextColorProperty, nameof(BaseTheme.SecondaryTextColor))
				.Paddings(10, 0, 10, 5)
				.Bind(Label.TextProperty, nameof(StoryModel.Description))
				.SemanticHint("The description of the news article.")
		}
	};

	enum Row { Title, Description, BottomPadding }
}