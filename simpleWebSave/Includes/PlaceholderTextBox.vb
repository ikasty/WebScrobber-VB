Imports System.ComponentModel
Imports System.Drawing
Imports System
Imports System.Windows.Forms

''' <summary>
''' Represents a Windows text box control with placeholder.
''' </summary>
Public Class PlaceholderTextBox
    Inherits TextBox

#Region "Properties"

    Private _placeholderText As String = DEFAULT_PLACEHOLDER
    Private _isItalics As Boolean = False
    Private _isPlaceholderActive As Boolean

    ''' <summary>
    ''' Gets a value indicating whether the Placeholder is active.
    ''' </summary>
    <Browsable(False)> _
        Public Property IsPlaceholderActive() As Boolean
        Get
            Return _isPlaceholderActive
        End Get
        Private Set(value As Boolean)
            If value <> _isPlaceholderActive Then
                _isPlaceholderActive = value

                RaiseEvent PlaceholderInsideChanged(Me, New PlaceholderInsideChangedEventArgs(value))
            End If
        End Set
    End Property


    ''' <summary>
    ''' Placeholder가 Italic으로 표시될 지의 여부를 설정합니다.
    ''' </summary>
    <Description("Placeholder가 Italic으로 표시될 지의 여부를 설정합니다."), Category("Appearance"), DefaultValue(False)> _
    Public Property PlaceholderItalics() As Boolean
        Get
            Return _isItalics
        End Get
        Set(value As Boolean)
            _isItalics = value

            ' If placeholder is active, assign new FontStyle
            If IsPlaceholderActive Then
                AssignPlaceholderStyle()
            End If
        End Set
    End Property


    ''' <summary>
    ''' Gets or sets the current placeholder in the Demo.PlaceholderTextBox.
    ''' </summary>
    <Description("Placeholder 텍스트를 설정합니다."), Category("Appearance"), DefaultValue(DEFAULT_PLACEHOLDER)> _
    Public Property PlaceholderText() As String
        Get
            Return _placeholderText
        End Get
        Set(value As String)
            _placeholderText = value

            ' Only use the new value if the placeholder is active.
            If IsPlaceholderActive Then
                Me.Text = value
            End If
        End Set
    End Property


    ''' <summary>
    ''' Gets or sets the current text in the Demo.TextBox.
    ''' </summary>
    <Browsable(True)> _
    Public Overrides Property Text() As String
        Get
            ' Check 'IsPlaceholderActive' to avoid this if-clause when the text is the same as the placeholder but actually it's not the placeholder.
            ' Check 'base.Text == this.Placeholder' because in some cases IsPlaceholderActive changes too late although it isn't the placeholder anymore.
            ' If you want to get the Text Property and it still contains the playerholder, an empty string will get returned.
            If IsPlaceholderActive AndAlso MyBase.Text = Me.PlaceholderText Then
                Return [String].Empty
            End If

            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property


    ''' <summary>
    ''' Occurs when the value of the IsPlaceholderInside property has changed.
    ''' </summary>
    <Description("Occurs when the value of the IsPlaceholderInside property has changed.")> _
    Public Event PlaceholderInsideChanged As EventHandler(Of PlaceholderInsideChangedEventArgs)

#End Region


#Region "Global Variables"

    ''' <summary>
    ''' Specifies the regular selected Font (usually specified by Designer).
    ''' </summary>
    Private ReadOnly regularFont As Font

    ''' <summary>
    ''' Specifies the regular selected FontColor (usually specified by Designer).
    ''' </summary>
    Private ReadOnly regularFontColor As Color

    ''' <summary>
    ''' Specifies the default placeholder text.
    ''' </summary>
    Private Const DEFAULT_PLACEHOLDER As String = "Placeholder"

    ''' <summary>
    ''' Flag to avoid the TextChanged Event. Don't access directly, use Method 'ActionWithoutTextChanged(Action act)' instead.
    ''' </summary>
    Private avoidTextChanged As Boolean = False

#End Region


#Region "Constructor"

    ''' <summary>
    ''' Initializes a new instance of the Demo.PlaceholderTextBox class.
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        ' Set Default
        IsPlaceholderActive = True

        ' Through this line the default placeholder gets displayed in designer
        Me.Text = Me.PlaceholderText

        ' Save Font
        regularFont = DirectCast(Me.Font.Clone(), Font)
        regularFontColor = Me.ForeColor

        SubscribeEvents()
        AssignPlaceholderStyle()
    End Sub

#End Region


    ''' <summary>
    ''' Insert Placeholder and assign Placeholder Style.
    ''' </summary>
    Public Sub Reset()
        AssignPlaceholderStyle()

        ActionWithoutTextChanged(Function() InlineAssignHelper(Me.Text, Me.PlaceholderText))
        Me.[Select](0, 0)
    End Sub

    ''' <summary>
    ''' Run an action with avoiding the TextChanged event.
    ''' </summary>
    ''' <param name="act">Specifies the action to run.</param>
    Private Sub ActionWithoutTextChanged(act As Action)
        avoidTextChanged = True

        act.Invoke()

        avoidTextChanged = False
    End Sub

    ''' <summary>
    ''' Set style to "Placeholder-Style".
    ''' </summary>
    Private Sub AssignPlaceholderStyle()
        ' Set classic placeholder style
        Me.Font = If(Me.PlaceholderItalics, New Font(Me.Font, FontStyle.Italic), New Font(Me.Font, FontStyle.Regular))
        Me.ForeColor = Color.LightGray

        ' Update IsPlayerholderInside property
        Me.IsPlaceholderActive = True
    End Sub

    ''' <summary>
    ''' Remove "Placeholder-Style".
    ''' </summary>
    Private Sub RemovePlaceholderStyle()
        ' Revert to designer specified font
        Me.Font = regularFont
        Me.ForeColor = regularFontColor

        ' Update IsPlaceholderInside property
        Me.IsPlaceholderActive = False
    End Sub

    ''' <summary>
    ''' Subscribe necessary Events.
    ''' </summary>
    Private Sub SubscribeEvents()
        AddHandler Me.TextChanged, AddressOf PlaceholderTextBox_TextChanged
    End Sub


#Region "Events"

    Private Sub PlaceholderTextBox_TextChanged(sender As Object, e As EventArgs)
        ' Check flag
        If avoidTextChanged Then
            Return
        End If

        ' Run code with avoiding recursive call
        ActionWithoutTextChanged(Sub()
                                     ' If the Text is empty, insert placeholder and set cursor to to first position
                                     If [String].IsNullOrEmpty(Me.Text) Then
                                         Reset()
                                         Return
                                     End If

                                     ' If the placeholder is active, revert state to a usual TextBox
                                     If IsPlaceholderActive Then
                                         RemovePlaceholderStyle()

                                         ' Throw away the placeholder but leave the new typed char
                                         Me.Text = Me.Text.Replace(Me.PlaceholderText, [String].Empty)

                                         ' Set Selection to last position
                                         Me.[Select](Me.TextLength, 0)
                                     End If

                                 End Sub)
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        ' When you click on the placerholderTextBox and the placerholder is active, jump to first position
        If IsPlaceholderActive Then
            Reset()
        End If

        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If IsPlaceholderActive Then
            Reset()
        End If

        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        ' Prevents that the user can go through the placeholder with arrow keys
        If (e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down) AndAlso IsPlaceholderActive Then
            e.Handled = True
        End If

        MyBase.OnKeyDown(e)
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

#End Region

End Class

''' <summary>
''' Provides data for the Demo.PlaceholderInsideChanged event.
''' </summary>
Public Class PlaceholderInsideChangedEventArgs
    Inherits EventArgs
    ''' <summary>
    ''' Initializes a new instance of the Demo.PlaceholderInsideChangedEventArgs class.
    ''' </summary>
    ''' <param name="mNewValue">The new value of the IsPlaceholderInside Property.</param>
    Public Sub New(mNewValue As Boolean)
        NewValue = mNewValue
    End Sub

    ''' <summary>
    ''' The new value of the IsPlaceholderInside Property.
    ''' </summary>
    Public Property NewValue() As Boolean
        Get
            Return m_NewValue
        End Get
        Private Set(value As Boolean)
            m_NewValue = Value
        End Set
    End Property
    Private m_NewValue As Boolean
End Class