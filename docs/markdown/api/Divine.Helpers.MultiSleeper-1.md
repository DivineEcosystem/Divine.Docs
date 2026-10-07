# <a id="Divine_Helpers_MultiSleeper_1"></a> Class MultiSleeper<T\>

Namespace: [Divine.Helpers](Divine.Helpers.md)  
Assembly: Divine.dll  

```csharp
public static class MultiSleeper<T> where T : notnull
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MultiSleeper<T\>](Divine.Helpers.MultiSleeper\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_Helpers_MultiSleeper_1_ExtendSleep__0_System_Single_"></a> ExtendSleep\(T, float\)

```csharp
public static void ExtendSleep(T key, float milliseconds)
```

#### Parameters

`key` T

`milliseconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Helpers_MultiSleeper_1_IsSleeping__0_"></a> IsSleeping\(T\)

```csharp
public static bool IsSleeping(T key)
```

#### Parameters

`key` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Helpers_MultiSleeper_1_Reset__0_"></a> Reset\(T\)

```csharp
public static void Reset(T key)
```

#### Parameters

`key` T

### <a id="Divine_Helpers_MultiSleeper_1_Sleep__0_System_Single_"></a> Sleep\(T, float\)

```csharp
public static void Sleep(T key, float milliseconds)
```

#### Parameters

`key` T

`milliseconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Helpers_MultiSleeper_1_Sleeper__0_"></a> Sleeper\(T\)

```csharp
public static Sleeper Sleeper(T key)
```

#### Parameters

`key` T

#### Returns

 [Sleeper](Divine.Helpers.Sleeper.md)

### <a id="Divine_Helpers_MultiSleeper_1_Sleeping__0_"></a> Sleeping\(T\)

```csharp
[Obsolete("Use IsSleeping")]
public static bool Sleeping(T key)
```

#### Parameters

`key` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Helpers_MultiSleeper_1_SleepUntil__0_System_Single_"></a> SleepUntil\(T, float\)

```csharp
public static void SleepUntil(T key, float rawGameTime)
```

#### Parameters

`key` T

`rawGameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

