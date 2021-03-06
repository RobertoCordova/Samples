// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// ThePlace_Info ViewModel interface.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public interface IThePlace_InfoViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentThePlace_InfoHtmlControl property.
        /// </summary>
		string CurrentThePlace_InfoHtmlControl { get; set; }

        /// <summary>
        /// Gets/Sets the Photos_AlbumListControlCollection property.
        /// </summary>
		ObservableCollection<photosCollectionSchema> Photos_AlbumListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the Selectedphotos_AlbumListControlCollection property.
        /// </summary>
		photosCollectionSchema Selectedphotos_AlbumListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the Diary_ListListControlCollection property.
        /// </summary>
		ObservableCollection<diarySchema> Diary_ListListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the Selecteddiary_ListListControlCollection property.
        /// </summary>
		diarySchema Selecteddiary_ListListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the Fellows_ListListControlCollection property.
        /// </summary>
		ObservableCollection<fellowsSchema> Fellows_ListListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the Selectedfellows_ListListControlCollection property.
        /// </summary>
		fellowsSchema Selectedfellows_ListListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the TheNextOne_ListListControlCollection property.
        /// </summary>
		ObservableCollection<TheNextOneSchema> TheNextOne_ListListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the SelectedTheNextOne_ListListControlCollection property.
        /// </summary>
		TheNextOneSchema SelectedTheNextOne_ListListControlCollection { get; set; }

        
        /// <summary>
        /// Gets the RefreshTheNextOne_ListListControlCollection command.
        /// </summary>
		ICommand RefreshTheNextOne_ListListControlCollection { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

	}
}
