using System.Collections.Generic;

namespace Couchcoding.Logbert.Gui.Helper
{
  /// <summary>
  /// Setting class used to store the curent filter.
  /// </summary>
  public sealed class FilterSettings : List<FilterSetting>
  {
  }

  /// <summary>
  /// The settings for each regex filter.
  /// </summary>
  public class FilterSetting 
  { 
    public string ExpressionRegex { get; set; }
    public bool IsFilterActive { get; set; }
    public int ColumnIndex { get; set; }
    public int OperatorIndex { get; set; }
  }
}
