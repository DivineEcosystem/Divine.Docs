# <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo"></a> Class CMsgBotWorldState.Types.RuneInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBotWorldState.Types.RuneInfo : IMessage<CMsgBotWorldState.Types.RuneInfo>, IEquatable<CMsgBotWorldState.Types.RuneInfo>, IDeepCloneable<CMsgBotWorldState.Types.RuneInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBotWorldState.Types.RuneInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.RuneInfo.md)

#### Implements

IMessage<CMsgBotWorldState.Types.RuneInfo\>, 
[IEquatable<CMsgBotWorldState.Types.RuneInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBotWorldState.Types.RuneInfo\>, 
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
[EnumerableExtensions.In<CMsgBotWorldState.Types.RuneInfo\>\(CMsgBotWorldState.Types.RuneInfo, params CMsgBotWorldState.Types.RuneInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo__ctor"></a> RuneInfo\(\)

```csharp
public RuneInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo__ctor_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_"></a> RuneInfo\(RuneInfo\)

```csharp
public RuneInfo(CMsgBotWorldState.Types.RuneInfo other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[RuneInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.RuneInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_LocationFieldNumber"></a> LocationFieldNumber

```csharp
public const int LocationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_TimeSinceSeenFieldNumber"></a> TimeSinceSeenFieldNumber

```csharp
public const int TimeSinceSeenFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_HasTimeSinceSeen"></a> HasTimeSinceSeen

```csharp
public bool HasTimeSinceSeen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Location"></a> Location

```csharp
public CMsgBotWorldState.Types.Vector Location { get; set; }
```

#### Property Value

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[Vector](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.Vector.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBotWorldState.Types.RuneInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[RuneInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.RuneInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Status"></a> Status

```csharp
public uint Status { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_TimeSinceSeen"></a> TimeSinceSeen

```csharp
public float TimeSinceSeen { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Type"></a> Type

```csharp
public int Type { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_ClearTimeSinceSeen"></a> ClearTimeSinceSeen\(\)

```csharp
public void ClearTimeSinceSeen()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Clone"></a> Clone\(\)

```csharp
public CMsgBotWorldState.Types.RuneInfo Clone()
```

#### Returns

 [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[RuneInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.RuneInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_Equals_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_"></a> Equals\(RuneInfo\)

```csharp
public bool Equals(CMsgBotWorldState.Types.RuneInfo other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[RuneInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.RuneInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_"></a> MergeFrom\(RuneInfo\)

```csharp
public void MergeFrom(CMsgBotWorldState.Types.RuneInfo other)
```

#### Parameters

`other` [CMsgBotWorldState](Divine.Protobufs.Dota2.CMsgBotWorldState.md).[Types](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.md).[RuneInfo](Divine.Protobufs.Dota2.CMsgBotWorldState.Types.RuneInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBotWorldState_Types_RuneInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

