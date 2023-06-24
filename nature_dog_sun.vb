Public Class TheNextStep
    Private _stepNumber As Integer
    Private _stepName As String
    
    Sub New(ByVal stepNumber As Integer, ByVal stepName As String)
        _stepNumber = stepNumber
        _stepName = stepName
    End Sub
    
    Public ReadOnly Property StepNumber As Integer
        Get
            Return _stepNumber
        End Get
    End Property
    
    Public ReadOnly Property StepName As String
        Get
            Return _stepName
        End Get
    End Property
    
    Public Function GetStep() As TheNextStep
        Select Case _stepNumber
            Case 1
                Return NextStep1()
            Case 2
                Return NextStep2()
            Case 3
                Return NextStep3()
            Case 4
                Return NextStep4()
            Case 5
                Return NextStep5()
            Case 6
                Return NextStep6()
            Case 7
                Return NextStep7()
            Case 8
                Return NextStep8()
            Case 9
                Return NextStep9()
            Case 10
                Return NextStep10()
            Case 11
                Return NextStep11()
            Case 12
                Return NextStep12()
            Case 13
                Return NextStep13()
            Case 14
                Return NextStep14()
            Case 15
                Return NextStep15()
            Case 16
                Return NextStep16()
            Case 17
                Return NextStep17()
            Case 18
                Return NextStep18()
            Case 19
                Return NextStep19()
            Case 20
                Return NextStep20()
            Case 21
                Return NextStep21()
            Case 22
                Return NextStep22()
            Case 23
                Return NextStep23()
            Case 24
                Return NextStep24()
            Case 25
                Return NextStep25()
            Case 26
                Return NextStep26()
            Case 27
                Return NextStep27()
            Case 28
                Return NextStep28()
            Case 29
                Return NextStep29()
            Case 30
                Return NextStep30()
            Case 31
                Return NextStep31()
            Case 32
                Return NextStep32()
            Case 33
                Return NextStep33()
            Case 34
                Return NextStep34()
            Case 35
                Return NextStep35()
            Case 36
                Return NextStep36()
            Case 37
                Return NextStep37()
            Case 38
                Return NextStep38()
            Case 39
                Return NextStep39()
            Case 40
                Return NextStep40()
            Case 41
                Return NextStep41()
            Case 42
                Return NextStep42()
            Case 43
                Return NextStep43()
            Case 44
                Return NextStep44()
            Case 45
                Return NextStep45()
            Case 46
                Return NextStep46()
            Case 47
                Return NextStep47()
            Case 48
                Return NextStep48()
            Case 49
                Return NextStep49()
            Case 50
                Return NextStep50()
            Case 51
                Return NextStep51()
            Case 52
                Return NextStep52()
            Case 53
                Return NextStep53()
            Case 54
                Return NextStep54()
            Case 55
                Return NextStep55()
            Case 56
                Return NextStep56()
            Case 57
                Return NextStep57()
            Case 58
                Return NextStep58()
            Case 59
                Return NextStep59()
            Case 60
                Return NextStep60()
            Case 61
                Return NextStep61()
            Case 62
                Return NextStep62()
            Case 63
                Return NextStep63()
            Case 64
                Return NextStep64()
            Case 65
                Return NextStep65()
            Case 66
                Return NextStep66()
            Case 67
                Return NextStep67()
            Case 68
                Return NextStep68()
            Case 69
                Return NextStep69()
            Case 70
                Return NextStep70()
            Case 71
                Return NextStep71()
            Case 72
                Return NextStep72()
            Case 73
                Return NextStep73()
            Case 74
                Return NextStep74()
            Case 75
                Return NextStep75()
            Case 76
                Return NextStep76()
            Case 77
                Return NextStep77()
            Case 78
                Return NextStep78()
            Case 79
                Return NextStep79()
            Case 80
                Return NextStep80()
            Case 81
                Return NextStep81()
            Case 82
                Return NextStep82()
            Case 83
                Return NextStep83()
            Case 84
                Return NextStep84()
            Case 85
                Return NextStep85()
            Case 86
                Return NextStep86()
            Case 87
                Return NextStep87()
            Case 88
                Return NextStep88()
            Case 89
                Return NextStep89()
            Case 90
                Return NextStep90()
            Case 91
                Return NextStep91()
            Case 92
                Return NextStep92()
            Case 93
                Return NextStep93()
            Case 94
                Return NextStep94()
            Case 95
                Return NextStep95()
            Case 96
                Return NextStep96()
            Case 97
                Return NextStep97()
            Case 98
                Return NextStep98()
            Case 99
                Return NextStep99()
            Case 100
                Return NextStep100()
            Case Else
                Return Nothing
        End Select
    End Function
    
    Private Function NextStep1() As TheNextStep
        Return New TheNextStep(2, "Take the first step")
    End Function
    
    Private Function NextStep2() As TheNextStep
        Return New TheNextStep(3, "Follow the path")
    End Function
    
    Private Function NextStep3() As TheNextStep
        Return New TheNextStep(4, "Be prepared")
    End Function
    
    Private Function NextStep4() As TheNextStep
        Return New TheNextStep(5, "Go the extra mile")
    End Function
    
    Private Function NextStep5() As TheNextStep
        Return New TheNextStep(6, "Take action")
    End Function
    
    Private Function NextStep6() As TheNextStep
        Return New TheNextStep(7, "Move forward")
    End Function
    
    Private Function NextStep7() As TheNextStep
        Return New TheNextStep(8, "Find solutions")
    End Function
    
    Private Function NextStep8() As TheNextStep
        Return New TheNextStep(9, "Explore new possibilities")
    End Function
    
    Private Function NextStep9() As TheNextStep
        Return New TheNextStep(10, "Make decisions")
    End Function
    
    Private Function NextStep10() As TheNextStep
        Return New TheNextStep(11, "Create opportunities")
    End Function
    
    Private Function NextStep11() As TheNextStep
        Return New TheNextStep(12, "Build something")
    End Function
    
    Private Function NextStep12() As TheNextStep
        Return New TheNextStep(13, "Grow")
    End Function
    
    Private Function NextStep13() As TheNextStep
        Return New TheNextStep(14, "Stay focused")
    End Function
    
    Private Function NextStep14() As TheNextStep
        Return New TheNextStep(15, "Be persistent")
    End Function
    
    Private Function NextStep15() As TheNextStep
        Return New TheNextStep(16, "Solve problems")
    End Function
    
    Private Function NextStep16() As TheNextStep
        Return New TheNextStep(17, "Adapt quickly")
    End Function
    
    Private Function NextStep17() As TheNextStep
        Return New TheNextStep(18, "Think outside the box")
    End Function
    
    Private Function NextStep18() As TheNextStep
        Return New TheNextStep(19, "Be innovative")
    End Function
    
    Private Function NextStep19() As TheNextStep
        Return New TheNextStep(20, "Be flexible")
    End Function
    
    Private Function NextStep20() As TheNextStep
        Return New TheNextStep(21, "Take risks")
    End Function
    
    Private Function NextStep21() As TheNextStep
        Return New TheNextStep(22, "Persevere")
    End Function
    
    Private Function NextStep22() As TheNextStep
        Return New TheNextStep(23, "Explore new ideas")
    End Function
    
    Private Function NextStep23() As TheNextStep
        Return New TheNextStep(24, "Focus on the goal")
    End Function
    
    Private Function NextStep24() As TheNextStep
        Return New TheNextStep(25, "Set objectives")
    End Function
    
    Private Function NextStep25() As TheNextStep
        Return New TheNextStep(26, "Learn from mistakes")
    End Function
    
    Private Function NextStep26() As TheNextStep
        Return New TheNextStep(27, "Seize opportunities")
    End Function
    
    Private Function NextStep27() As TheNextStep
        Return New TheNextStep(28, "Plan ahead")
    End Function
    
    Private Function NextStep28() As TheNextStep
        Return New TheNextStep(29, "Explore alternatives")
    End Function
    
    Private Function NextStep29() As TheNextStep
        Return New TheNextStep(30, "Think critically")
    End Function
    
    Private Function NextStep30() As TheNextStep
        Return New TheNextStep(31, "Gather resources")
    End Function
    
    Private Function NextStep31() As TheNextStep
        Return New TheNextStep(32, "Develop strategies")
    End Function
    
    Private Function NextStep32() As TheNextStep
        Return New TheNextStep(33, "Be organized")
    End Function
    
    Private Function NextStep33() As TheNextStep
        Return New TheNextStep(34, "Set goals")
    End Function
    
    Private Function NextStep34() As TheNextStep
        Return New TheNextStep(35, "Take charge")
    End Function
    
    Private Function NextStep35() As TheNextStep
        Return New TheNextStep(36, "Be passionate")
    End Function
    
    Private Function NextStep36() As TheNextStep
        Return New TheNextStep(37, "Think ahead")
    End Function
    
    Private Function NextStep37() As TheNextStep
        Return New TheNextStep(38, "Be positive")
    End Function
    
    Private Function NextStep38() As TheNextStep
        Return New TheNextStep(39, "Break barriers")
    End Function
    
    Private Function NextStep39() As TheNextStep
        Return New TheNextStep(40, "Build relationships")
    End Function
    
    Private Function NextStep40() As TheNextStep
        Return New TheNextStep(41, "Be creative")
    End Function
    
    Private Function NextStep41() As TheNextStep
        Return New TheNextStep(42, "Discover solutions")
    End Function
    
    Private Function NextStep42() As TheNextStep
        Return New TheNextStep(43, "Be proactive")
    End Function
    
    Private Function NextStep43() As TheNextStep
        Return New TheNextStep(44, "Focus on details")
    End Function
    
    Private Function NextStep44() As TheNextStep
        Return New TheNextStep(45, "Be disciplined")
    End Function
    
    Private Function NextStep45() As TheNextStep
        Return New TheNextStep(46, "Find the right people")
    End Function
    
    Private Function NextStep46() As TheNextStep
        Return New TheNextStep(47, "Manage time")
    End Function
    
    Private Function NextStep47() As TheNextStep
        Return New TheNextStep(48, "Improve effectiveness")
    End Function
    
    Private Function NextStep48() As TheNextStep
        Return New TheNextStep(49, "Increase efficiency")
    End Function
    
    Private Function NextStep49() As TheNextStep
        Return New TheNextStep(50, "Make progress")
    End Function
    
    Private Function NextStep50() As TheNextStep
        Return New TheNextStep(51, "Assess situations")
    End Function
    
    Private Function NextStep51() As TheNextStep
        Return New TheNextStep(52, "Try new things")
    End Function
    
    Private Function NextStep52() As TheNextStep
        Return New TheNextStep(53, "Be confident")
    End Function
    
    Private Function NextStep53() As TheNextStep
        Return New TheNextStep(54, "Have courage")
    End Function
    
    Private Function NextStep54() As TheNextStep
        Return New TheNextStep(55, "Recognize potential")
    End Function
    
    Private Function NextStep55() As TheNextStep
        Return New TheNextStep(56, "Look to the future")
    End Function
    
    Private Function NextStep56() As TheNextStep
        Return New TheNextStep(57, "Create something great")
    End Function
    
    Private Function NextStep57() As TheNextStep
        Return New TheNextStep(58, "Delegate tasks")
    End Function
    
    Private Function NextStep58() As TheNextStep
        Return New TheNextStep(59, "Invest in yourself")
    End Function
    
    Private Function NextStep59() As TheNextStep
        Return New TheNextStep(60, "Organize information")
    End Function
    
    Private Function NextStep60() As TheNextStep
        Return New TheNextStep(61, "Read constantly")
    End Function
    
    Private Function NextStep61() As TheNextStep
        Return New TheNextStep(62, "Look for answers")
    End Function
    
    Private Function NextStep62() As TheNextStep
        Return New TheNextStep(63, "Research thoroughly")
    End Function
    
    Private Function NextStep63() As TheNextStep
        Return New TheNextStep(64, "Make adjustments")
    End Function
    
    Private Function NextStep64() As TheNextStep
        Return New TheNextStep(65, "Overcome obstacles")
    End Function
    
    Private Function NextStep65() As TheNextStep
        Return New TheNextStep(66, "Be prepared for change")
    End Function
    
    Private Function NextStep66() As TheNextStep
        Return New TheNextStep(67, "Manage expectations")
    End Function
    
    Private Function NextStep67() As TheNextStep
        Return New TheNextStep(68, "Improve communication")
    End Function
    
    Private Function NextStep68() As TheNextStep
        Return New TheNextStep(69, "Focus on success")
    End Function
    
    Private Function NextStep69() As TheNextStep
        Return New TheNextStep(70, "Achieve balance")