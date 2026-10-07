# <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates"></a> Class CMsgTalentWinRates

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTalentWinRates : IMessage<CMsgTalentWinRates>, IEquatable<CMsgTalentWinRates>, IDeepCloneable<CMsgTalentWinRates>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTalentWinRates](Divine.Protobufs.Dota2.CMsgTalentWinRates.md)

#### Implements

IMessage<CMsgTalentWinRates\>, 
[IEquatable<CMsgTalentWinRates\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTalentWinRates\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgTalentWinRates\>\(CMsgTalentWinRates, params CMsgTalentWinRates\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates__ctor"></a> CMsgTalentWinRates\(\)

```csharp
public CMsgTalentWinRates()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates__ctor_Divine_Protobufs_Dota2_CMsgTalentWinRates_"></a> CMsgTalentWinRates\(CMsgTalentWinRates\)

```csharp
public CMsgTalentWinRates(CMsgTalentWinRates other)
```

#### Parameters

`other` [CMsgTalentWinRates](Divine.Protobufs.Dota2.CMsgTalentWinRates.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_AbilityIdFieldNumber"></a> AbilityIdFieldNumber

```csharp
public const int AbilityIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_GameCountFieldNumber"></a> GameCountFieldNumber

```csharp
public const int GameCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_LastRunFieldNumber"></a> LastRunFieldNumber

```csharp
public const int LastRunFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_WinCountFieldNumber"></a> WinCountFieldNumber

```csharp
public const int WinCountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_AbilityId"></a> AbilityId

```csharp
public int AbilityId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_GameCount"></a> GameCount

```csharp
public uint GameCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_HasAbilityId"></a> HasAbilityId

```csharp
public bool HasAbilityId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_HasGameCount"></a> HasGameCount

```csharp
public bool HasGameCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_HasLastRun"></a> HasLastRun

```csharp
public bool HasLastRun { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_HasWinCount"></a> HasWinCount

```csharp
public bool HasWinCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_LastRun"></a> LastRun

```csharp
public uint LastRun { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTalentWinRates> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTalentWinRates](Divine.Protobufs.Dota2.CMsgTalentWinRates.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_WinCount"></a> WinCount

```csharp
public uint WinCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_ClearAbilityId"></a> ClearAbilityId\(\)

```csharp
public void ClearAbilityId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_ClearGameCount"></a> ClearGameCount\(\)

```csharp
public void ClearGameCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_ClearLastRun"></a> ClearLastRun\(\)

```csharp
public void ClearLastRun()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_ClearWinCount"></a> ClearWinCount\(\)

```csharp
public void ClearWinCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_Clone"></a> Clone\(\)

```csharp
public CMsgTalentWinRates Clone()
```

#### Returns

 [CMsgTalentWinRates](Divine.Protobufs.Dota2.CMsgTalentWinRates.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_Equals_Divine_Protobufs_Dota2_CMsgTalentWinRates_"></a> Equals\(CMsgTalentWinRates\)

```csharp
public bool Equals(CMsgTalentWinRates other)
```

#### Parameters

`other` [CMsgTalentWinRates](Divine.Protobufs.Dota2.CMsgTalentWinRates.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_MergeFrom_Divine_Protobufs_Dota2_CMsgTalentWinRates_"></a> MergeFrom\(CMsgTalentWinRates\)

```csharp
public void MergeFrom(CMsgTalentWinRates other)
```

#### Parameters

`other` [CMsgTalentWinRates](Divine.Protobufs.Dota2.CMsgTalentWinRates.md)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTalentWinRates_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

