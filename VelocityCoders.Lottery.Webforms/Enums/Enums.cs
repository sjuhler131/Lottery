namespace VelocityCoders.Lottery.WebForms
{
    public enum GameNavigation
    {
        /// <summary>
        /// Default to None
        /// </summary>
        None,

        /// <summary>
        /// Page contains list of Games
        /// </summary>

        GameList,

        /// <summary>
        /// Page contains Game Form
        /// </summary>

        GameForm,

        /// <summary>
        /// Page contains relationship between Game and Drawing
        /// </summary>

        DrawingForm,

        /// <summary>
        /// Page contains relationship between Game and Game Detail
        /// </summary>

        GameDetail
    }

    public enum DrawingNavigation
    {
        /// <summary>
        /// Default to None
        /// </summary>

        None,

        /// <summary>
        /// Page contains list of Drawings
        /// </summary>

        DrawingList,

        /// <summary>
        /// Page contains Drawing Form
        /// </summary>

        DrawingForm,

        /// <summary>
        /// Page contains relationship between Drawing and Game
        /// </summary>

        DrawingGame,

        /// <summary>
        /// Page contains relationship between Drawing and Drawing Numbers
        /// </summary>

        DrawingNumbers
    }

}

