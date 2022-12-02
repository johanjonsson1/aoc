﻿namespace AoC2021;

public class Day10 : Day
{
    public override string Title => "--- Day 10: Syntax Scoring ---";

    public override void PartOne()
    {
        base.PartOne();
        var input = Input.ToStringList();

        var totalScore = 0;
        foreach (var line in input)
        {
            var stack = new Stack<char>();
            foreach (var c in line)
            {
                if (IsClose(c))
                {
                    if (GetClose(stack.Peek()) == c)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        totalScore += GetScore(c);
                        break;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
        }

        Console.WriteLine(totalScore); //366027
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Input.ToStringList();

        var scores = new List<long>();
        foreach (var line in input)
        {
            var stack = new Stack<char>();
            var isIncomplete = true;
            foreach (var c in line)
            {
                if (IsClose(c))
                {
                    if (GetClose(stack.Peek()) == c)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isIncomplete = false;
                        break;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            if (isIncomplete)
            {
                long totalScore = 0;
                while (stack.TryPop(out var c))
                {
                    totalScore *= 5;
                    totalScore += GetPoints(GetClose(c));
                }

                scores.Add(totalScore);
            }
        }

        var ordered = scores.Order().ToList();
        var middleIndex = (int)Math.Round(ordered.Count / 2m, MidpointRounding.AwayFromZero) - 1;
        var result = ordered[middleIndex];

        Console.WriteLine(result); // 1118645287
    }

    private static int GetPoints(char c)
    {
        return c switch
        {
            ')' => 1,
            ']' => 2,
            '}' => 3,
            '>' => 4,
            _ => throw new ArgumentOutOfRangeException(c.ToString())
        };
    }

    private static int GetScore(char c)
    {
        return c switch
        {
            ')' => 3,
            ']' => 57,
            '}' => 1197,
            '>' => 25137,
            _ => throw new ArgumentOutOfRangeException(c.ToString())
        };
    }

    private static char GetClose(char c)
    {
        return c switch
        {
            '(' => ')',
            '[' => ']',
            '{' => '}',
            '<' => '>',
            _ => throw new ArgumentOutOfRangeException(c.ToString())
        };
    }

    private static bool IsClose(char c)
    {
        return c is ')' or ']' or '}' or '>';
    }

    private static string Input = @"{([[[(<<[{[[[[(){}][()]][({}())]]]<{((<>[]){[]<>})({()()}(<>[]))}<{{{}()}{[]()}}>>})[<(<[[<><>][{}{
([(<(((<[({{({(){}}<{}()>)((<>{})[{}<>})}}[{[(<>())[[]]]{{[][]}(<><>)}}{<<{}()>([]())>([<>][{}])}])](<[{[
{{[[<[<(<<<{((<>[])([]<>))(<{}><()[]>)}[(((){}){<>[]})<{(){}}<<>[]>>]>{[{{<>{}}<()<>>}<<<>[]>([]<>)>][
<[{<(({([[([({{}[]}{<><>})<<[]{}>>]<<<{}{}>((){})><{{}()}<{}[]>>>)](([<([]{})<{}<>>>(<[][]>{()()})
{{<(([<[[{<{({{}<>}({}()))<[<>[]](<>[])>}><[(((){})){[()]<<>[]>}][{{<><>}(<>{})}<<()[]>({}())>]>}<[{[(()<>)
[<{{{({{[<([<{<><>}{<>{}}><<[][]>[{}<>]>]({<[]{}>[[]{}]}{([]())([][])})){<{[[][]]([]())}>([[[
{[<[<<([[<(<<<<>>({})>><({(){}}(<>{}))[{()()}(()[])]>}[<({[]})<[()[]](<>{})>>[<({}{})[()<>]><{(){}}>]]>
[(<({{<[{<(<((<><>)<[]<>>)({<><>}<<>()>)><<<()<>>[()()]>{<<>{}>[()<>]}>){{[([]{})<<><>>]([<
<<{{<{<{([{(<{<><>}>((()[])<<>{}>))({<{}>}<[[]()][<><>]>)}<{([[]()]{<>{}})}{(<<>()>{<>{}})[{<><>}{<><>}]}>]
{(<{<({{([[{<({})[()()]><[{}<>][{}[]]>}<<<[]{}>[<>()]>({{}{}}[{}[]])>]<({[[][]]({}())}[(()[]](<
<[<{[<<[(((<([()()]<()()>]([()[]][{}{}])>)[[[{<>}[<>[]]]][(<()()><<>>)<<{}{}>{<>}>]])([(<({}<>)[()()]>
(<<{{([<[<[<[{[]()}[{}<>]]<(<>[])[{}]>><[{()[]}[()[]]]<([]<>)(()())>>]{{{{()<>}{()()}}[(<><
<[([(<[[[(<[(<{}()>{()()})<<()[]>{(){}}>]><<({[]<>}<{}{}>)[{[][]}{[]{}}]>{<{()()}(()[])>{[<><>
[[([[({{{[[(<<()()>[<>[]]>)<[<<>{}>]([[]()][(){}])>]<(<{()<>}[[][]]>(([]{})[[]()]))[<({}[])
<<{[({<[[[[[{<<>()>{<>{}}}[<()()>]](<<{}<>>{{}<>]><[{}<>]<()<>>>)][((<[]{}>[[]])<{{}()}>)[((<>{}))<<<>{}>(
[[<[[<<(({{<({[]<>}([][]))>{([[]()]{{}<>}){[[]{}][()<>]}}}({{({}()}[[][]]}(((){}){<>})}(<[{}<>]{()()}>
{[{<[[(({<({[{()[]}[[][]]]}(({<><>}<{}[]>)))>}{[{(<{[]{}}{{}[]}>{<<><>>})}<{{[[][]]{<>()>}}<{
{[({<{<{[[([[<()<>}{[]<>}][<<>[]>([])]])]([({{[]()}({}())}([<>()](<><>)))])]{{<[<<[]<>>(()())>(<<>()>{<>
({([<({((<({<<()<>>[(){}]>[(<>{}){<>[]}]}){([{{}[]}])([({}()){<><>}]{[<><>]([]())))}><<[([{}[]])](
<{[{<{<<[<<<[(()<>){[][]}]([()<>]({}{}))>{(<{}{}>[<>{}])[{{}()}[(){}]]}><({<[]<>>[<>{}]}{([]<>)<[]{})})<([{}(
<[<<(({<[{{(<[[]<>]<<>()>>([{}<>]{[]()}))}{<(([]<>)<()<>>)[({}[])<[]{}>]><<<{}[]>{{}<>}>({<>[]}[(){}])>}}<(
[[[[[[(((<{<{(()())<<>{}>}>(<[<><>]({}[])})}{{<[()<>]<[]{}>>[{{}<>}[[]()]]}({<<>[]>}[<{}<>
[(({{<{[<[[(<(()())<<>()>>[<<><>><()()>])(<[{}()]><{[]()}<{}{}>>)][<[({}())<{}<>>][({}[])(()[])]>(((
(([<({{<{{[<<{[]()>(<>{})>[[{}]{{}{}}]>{<<[]{}>>[([][])[<><>]]}]<<[<<>[]>({}<>)]({<>[]}<{}{}>)>[{<{}<>>{[]()}
{(<<[{<<{({(<(<>{})(()())><(<>[]){[]<>}>){[(<>[]){[]()}]{[<>()][{}<>]]}}{([[{}()]]((<><>)))[([{}()]([]()))
[{({[[{{[<<{{[{}<>][<>]}([(){}]{<><>})}><(<[()[]][{}{}]><{[]{}}({})>)(<({}[])<()()>>{<{}{}>{[
([(({{<[<(([({{}<>}[[][]])<({}[]){{}()}>]{[[{}[]]][((){})]})<[{{{}<>}([]{})}{{[]<>}}]>)[{{<([]())({})>
<{{{<<(<{<(<{{<>()}}{({}<>)}>)>}((<{[<{}{}>([]<>)]<<[]()>[{}()]>}<{[<><>]<[]{}>}{{(){}}[[]()]}>>[({(()<>)<{}
((<[{<<{{{([[[[][]](<>[])]]{<({}[])([][])]<{{}{}}{()[]}>})}[[{<{<>[]}{<>{}}>}]]}{<[[((()<>)<()[]>){<()>({}[]
({[[{<{{<<([(<[]<>>{<>{}})<{()[]}(<>())>])<[{[<><>]({}{})}][<({}())><{()<>}(<>())>]>>>{{(([
<((<<(<(<<{{{[{}]<()<>>}{[[]<>]{<><>}}}<[[<>{}]{()()}][<()()>{[][]}]>}{[{[{}()][{}{}]}(<{}()>[{}<>])]}>>
(([<({<[[(<(<([]())({}<>)>([{}()]{<>[]}))<{{{}{}}([]{})}<({}{})<{}<>>>>>[{{<<>[]><<>{}>}({{}<>})}{({[]()}(()<
{[((<({[([(([{(){}}{{}()}][<[]()>{(){}}])[[[{}[]]{{}<>}]<{[]{}}>]){(<[<><>][[][]]>)[{{<>{}}((){})>[([]())[
[[<[<{({[({{([()<>]<()()>)}[<<[]()>>]}((({()()})(<{}>[<>()]))[(({}{}){[]}>(([][])<()()>)]))[{<[<[
[<<([((<<(([[({}{})((){})]<({}[])[{}{}]>]<{{<><>}<[]>}>)[<{{<>()}<()()>}{<<>{}>[[]()]}>[(([][])
{(<(<[[((<([{<[][]><()>}[[<>{}]]]<<((){}){[]())>[<()<>>(<>[])]>)<{<[[]][<>{}]>({<><>}[<>()])}({{{
(<{({({<[[((<<{}<>><<>()>>({{}}<<>[])))[<<{}[]><<><>>>{{[]{}}(())}])[<[([]())<<>{}>]>[[[<><
<[{[[{[({{{([<()()><<>[]>])([([]{})(<>())]{([]<>){()[]}})}<{({{}<>}{[]})([()()])}<[[[]<>><<>{}>]<[()()]<(){}
<<[<[{{({(({(<[]()>({}{}))([{}[]][[]()])}{{(()[]){<><>}}([<><>]{{}})})[{[[{}{}]({}())]{<<>{}
{{{[[[[[<(<<{(()[]){()<>}}<<(){}>(()())>>({(()[])}<<[][]>[<>()]>)>)[{[<(<>())>{<(){}>[{}{}]}]
(([<[[{(([([<<<>{}>((){})>[({}{})<()<>>]]([((){})({}())]])[[{[()()][()[]]}([[][]](<>()))][<{()<
([<{{[[{<{[({<()[]>{[]<>}}([()<>]<[]()>))]}>{[<({({}{})})>{{<[<>{}][()<>]>({[]}{[]<>})}{<[[]{}](<>())
[{<<<{{((<{<<{[]()}<<>{}>>{((){}}{()()}}>}{[((()<>){<>})]({{()()}{(){}}}(<<>()>))}><[<{<{}><(
(((<<<<{((((<{<>[]}{<>()}>)(((<>{})(<><>))))))}><<{<(<<<[]{}><[]>><{[]()}{[]())>>{{<{}<>>}{{
{{[{<(({[[[<[[(){}]]><<[{}{}]({}())>{{[][]}[()()]}>]<{<[<>{}][<>{}]>[(()[])<()[]>]}[{<{}<>>({
{[{{[<[(((([{{{}{}}}({<>{}}[[][]])]){[<([]<>)([][])><{()<>}([]())>](<({}<>)<()>>(<()[]>{{}()}))
{{[(<<[<{<{[[<<><>>[()()]]]<(([]<>))<[[]{}]<[]>>>}>}>{{[<<<[()()]({}())>{<{}()>(<>[])}>([[(){}]<{}[]>]({(
[[[<<(<[{<[[<{<>[]}{{}[]}>]{({<>{}}[<>]]<({}{})[<><>]>}]((([{}{}][{}<>]))[({<>()}(<>{}))])
{{((<<[({<<<{[(){}]({}())}([<>{}]<(){}>)>([(()<>)<{}[]>]<<[]{}><<>{}>>)>[[<{<>}((){})>[{()[]}<{}<>>]](
((<<<<(<[{((<[[]{}](<><>)>{(()<>){()[]}}))}{<({(()())[(){}]}[[[]<>]<{}<>>])<([()[]])[{{}{}}{<><>}]>]}][<[{{
[[({<{{([([<{<<>()><()()>}>((<{}<>>{<>{}})[(()<>)[{}[]]])])[{{(([]())[<><>])({<>[]}(<>{}))}[[<[]><<>[]>]({[
[[(<(<[[(<{(({<>()}(<>[])){<<>[]>{()}}){({<>()}((){}))<<{}[]>[<><>]>}}{({<<>[]>[{}<>]})[[{(
({[<({<{<(<({([]<>){{}[]}}<({}{})[{}{}]>){{([]<>){(){}}}(<[]<>>{<><>})}><[[(<>())]{([]<>)}
{{[[[<{<(<{[(({}[])({}{}))<<()<>>>][<[{}{}]{()[]}>(<[]<>>{<><>})]}<{[<<>()>]<([]())<<>()>>}>>)
(({{{<(([[<(<((){})><[[]{}][{}()]>)<{[{}{}]}<(<>[])>>>]])({{{<[<()<>>{()<>}]>([<<>{}>(()())]<<<>{}>{[]}
{{[[[[({<{[{<[()<>]<<><>>>({<>()}<<>{}>)}(({[]<>}([]))<<<><>>[[]<>]>)]<(<<()()>([]<>>>{({}{}){()()}})[[[<><
[<<{[[([(<{[{{[]()}{[][]}}{{[]()}{(){}}}]{{[{}<>]([]<>)}(<{}()><<>()>)}}<[<{{}<>}<[]<>>><[[]{}]([]{})>][{({
[[[<<(({(<<((<{}<>><(){}>)<([]<>)(()[])>)[((<>())<(){}>){{(){}}{<>[]}}]><<({(){}}{{}<>})>{[<[]{}><[]{}>](<()
({({{<[<<<[{{<{}[]>[(){}]}{(<>[]){{}}}}]{[[{[][]}{[]<>}]{(())([]{})}](<({}{})(()())><{<>()}>)}>>>]([({
<[(((<{<{[<{{{[]<>}{<><>}}{([][])[<>()]}][[[()<>]<{}[]>](({}<>)<[]()>)]>][(<{{{}[]}((){})}{{<>{}}({}()
{<{[({<<(<[<([<>]<[]()>)<({}()){()[]}>>([{()[]}[{}{}]])]>(([{[[]<>][[]<>]}[[<>()]<<>()>]>(((()[]){<>{}}){
<(({<{[(<([(<{[]{}}{[]()}>){{(<><>){[][]}}[{{}()}<[][]>]}])>(<{{{[()<>][()<>]}({{}[]}[[]{}])}}(<{{[]{}
{<[<[{{<<<([[[{}[]]{<>[]}](<<>[]>[()()])][(([]<>)]])>([[<{()}{<><>}>[(<>[])<{}()>]]]{<{<[]{}>[[]
([{[[<<<<{<[({[]{}}(<>()))[<{}<>>[[]{}]]](([{}<>]){{[]()}[<>[]]})>[{(([][])[{}[]]){(<><>)(<>[])}}(<{()<>}
<<(([<{[((<[(<(){}>[<><>])[<<>[]><()())]]{<{()[]}(()<>)>}>)[<<{<(){}><{}()>}{[{}<>]<(){}>}>><[<{<>[]}{[][
(<<[<{<(<<({<([]{}){[][]}>{<[][]>{<>{}}}}[(([]())<<><>>){<{}><<>[]>}])(<{[<>[]]}>{<[{}<>}{<>{}}><{<><>}{()[
[[[[{<[{[<(<[(()())<{}[]>][(()())<()>]><{{()()}[<>{}]}[({}()><[]<>>]>)<{{[[]<>]<[][]>}{[<><>]
{{<(({{<{(<([<[][]>(()[])])<<{<><>}<[]<>>><(<>{})>>><{[[[]{}]{<>[]}](<<>{}>(<>[]))}[[<()<>><()<>>]<{()<
<[({<[[[(<{[(<{}()><(){}>)(<[][]><<>{}>)]<<{{}[]}<{}()>>[(<>())<<><>>]>>{<[([]{})[(){}]]{[(
[{<<<({<[[[<{{<>{}}<()<>>}{[[]()][(){}]}>{(({}[])<[]{}>){<()>(()[])}}]<{<({}<>)<{}[]>>[<{}{}><<><>
{<<[(<<<(<[<<{<><>}>({<>()}(()[]))>[([<><>][[]{}])(([]<>))]]>)>[({[<([[][]]({}))<((){}){[]<>}]>[[
([<{<(<<{({<{<(){}>({}<>)}}{<[{}()][()<>]>{<[]<>>{<>[]}}}}<({[{}{}](<>[])}(<[][]>[{}<>]))<
{([<<<<{[<<[[<{}{}><[][]>]<{{}()}[()[]]>]<[(()[]){<>[]}][[[]()][()<>>]>>(<[{<>()}(<><>)]{<<>{}>{
[[([(([[[<[((<()()>)([[]{}]<[]()>))]><{{[[[]{}]([]{})][(()<>)<{}<>>]}([{()<>}]{[<>()][{}[]]})}
<<{<[<<<({{(<<[]>([])>{<{}<>><<><>>}){<<()<>><()<>>><(<>[])<{}<>>}}}{([{[]<>}{<>{}}](<()()>[{}{}]))<{<[]>
[{{(([{[<{<{{<<><>><{}[]>}}{<(<>{}){[]}>[([]{})[[]{}]]}>(({[{}]<()[]>}))}><<[{(<{}[]><[][]>)
[[[<[<[{{[<[{([]())[()[]]}{<{}<>>[()[]]}]<<{[][]}<()[]>>(<{}<>>{[]{}})>>{<<<{}()>><([]<>)[<>()]>>{{(
{{{([{({[((((([][])[[]()])[(<><>)[()[]]])[[[<>[]]{{}<>}]<[{}[]]([][])>]){[[[[][]]<()<>>](<{}<>><{}{}>
<<<[({{(<((<<{{}()]<()>>(<(){}><<>{}>)>(<{<>()}<[][]>><{<><>}{[]()}>))[(<([][])[<><>]>(<()()>{{}
<[(([[(([[({[[[]()]{()()}](<<>{}>)}){<{{<>[]}{{}{}}}{<[]()>[{}{}]}][(<()[]>[<>[]])((<>{}))]}]{[<<<<>
({{[{<[{([[({[(){}]}[{[]{}}<(){}>])<<({})[[]()]>>]<(({(){}}<[]>)<[<>{}}(<>())>)>])}<<<<[[[[]<>][{}()]]
{{{[[([<{({{{<(){}><{}()>}([()()]<<>[]>)}<<[<>()]{{}<>}><<<><>>>>})([(<(()[])({}<>)>([{}<>](<>[]))){(<<>>
<([([[<{{({{[[<>[]]({}[])]}(<({}())><[<>{}]>)}{[(<{}[]>(<>[]))([[]{}]{[]})]({([][])(<>())})}
[({({{[{<{{(([{}]){<{}[]>([][])})({[[][]]<<>[]>}[<()<>><[]>])}<<<<{}{}>{[]()}>({[][]}[()()])>({([][])[<>{}]}[
({<{(<([<[{<{<<>[]>({}{}>}([()<>]<[]<>>)>({{(){}}<<><>>}[({}{})])}]><<[(<<<>{}>([]())>)[[<[]<>>(
<[{<{<<<({[([({}<>){()()}][<()()>(<><>)]){<{()[]}<<>[]>>{{{}()}[<>[]]}}](((<[]()>{<>()})(({}<>)([]{})))({(
<<{<[[[<[<[[({()()}({}[]))[<()()>[()<>]]]]>][{[<<({}<>)[[][]]>{{{}[]}<()[]>)>]<{{[()[]][[]()]}}{<[
<{<{({({[{<{[{()<>}]<<<><>><[]<>>>}[{<[]><(){}>}<{[]{}}(()<>)>]><{<{{}()}{(){}}>{<()<>>{[]()}}}((([]<>)<<>
{(({[([(((<<([()()]<<>[]>)[<<>()>(<>{})]>[<<<><>><()>>]>[((<()()>((){})))[[<()<>><()()>)({{}[]}
<[<[<{<[{[[([[()()]<{}<>>]){[[{}[]][<>()]]{[[]{}][()<>]}}]]<[{((<>())[[][]]>}([[()<>]<[][]>])](({[
((<<[[{<({[([{<><>}[<>{}]]){(([]{}){(){}})}](<({{}()}<()<>>)({[]()}[[][]))>{{{{}()}[[][]]}<(<>{}){<>[]}>}
<{{{[([({{[(<<[]<>>[{}<>]><<[]{}>(())>)<[[<>{}]<{}<>>]<{()}<{}{}>>>]}{{[<(<>{})<[]()>><[(){}]>][{([]())}[<
[{<[<(<<{({[[<[]<>><()()>]([()()]<<>{}>)]}{(<{[]()}([]<>)><{()[]}>){<<[]()><{}<>>>({()}<<>[]>)}})}{
[{(({[{[{(<[(<[]{}>(<><>))]<[{()}({}())]>><<[({}[]){<><>}](<[][]>[()[]])>[[([][])([]<>)](([]{}])]>)}]<[<[
<({[([(<(((({(<>())<{}[]>}[(<>[]){()[]}]))){[([([]{})(<>()]]([()()][{}<>]))<<{{}}(<>[])>{{()
((({{({<{<({[(<>[]){()()}]([{}[]][{}{}])})(<<{[]{}}>{<[]<>>{()[]}}>)><{{{{{}()}}{[{}[]]<<>[]>}
(<[<<[([[{<[<({}()){()}>(<(){}><<><>>)]>{{([()[]]<<>()>)(<[]<>>)}{[{<>[]}[<>()]](<<>()><()[]
((<<({<((<(<({<><>}({}<>))({{}{}}(<>()))>((([]()){(){}})[(()())(()())]>)>){{<([{<>()}(<><>)]<{<>()
(({(<[({({([<{[]()}<<>()>>{(()<>)[[]()]}]{{[()()]((){})}{[{}<>]{(){}}}})}<<<(<()()>[{}{}])<([]{}){{}[]
{({[[{([[[<((<(){}>{{}()})[(<>{})])([[<>[]]<()[]>][(()())<[]{}>]>>]((({[{}<>]<{}{}>})({<{}[]>}{(<>
[[(({<<{[(<<(([][]){{}<>}){[{}[]]({}[])}>(({<><>})<(()<>)[<>()]})>{({[[]{}]((){})}[([]())])})(({([[][]]
<[<{[<<<{[{(<[<>[]]>{{(){}}[[]()]})}[<{[{}{}]}><(<{}()]{{}{}}){({}[])}>]]}>[({{(<({}[])({}<>)>[{{}<>}])}{";
}