# <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState"></a> Class CMsgServerToGCReportCheerState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCReportCheerState : IMessage<CMsgServerToGCReportCheerState>, IEquatable<CMsgServerToGCReportCheerState>, IDeepCloneable<CMsgServerToGCReportCheerState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCReportCheerState](Divine.Protobufs.Dota2.CMsgServerToGCReportCheerState.md)

#### Implements

IMessage<CMsgServerToGCReportCheerState\>, 
[IEquatable<CMsgServerToGCReportCheerState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCReportCheerState\>, 
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
[EnumerableExtensions.In<CMsgServerToGCReportCheerState\>\(CMsgServerToGCReportCheerState, params CMsgServerToGCReportCheerState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState__ctor"></a> CMsgServerToGCReportCheerState\(\)

```csharp
public CMsgServerToGCReportCheerState()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState__ctor_Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_"></a> CMsgServerToGCReportCheerState\(CMsgServerToGCReportCheerState\)

```csharp
public CMsgServerToGCReportCheerState(CMsgServerToGCReportCheerState other)
```

#### Parameters

`other` [CMsgServerToGCReportCheerState](Divine.Protobufs.Dota2.CMsgServerToGCReportCheerState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_CheerConfigFieldNumber"></a> CheerConfigFieldNumber

```csharp
public const int CheerConfigFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_CheerStateFieldNumber"></a> CheerStateFieldNumber

```csharp
public const int CheerStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_CheerConfig"></a> CheerConfig

```csharp
public CMsgCheerConfig CheerConfig { get; set; }
```

#### Property Value

 [CMsgCheerConfig](Divine.Protobufs.Dota2.CMsgCheerConfig.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_CheerState"></a> CheerState

```csharp
public CMsgCheerState CheerState { get; set; }
```

#### Property Value

 [CMsgCheerState](Divine.Protobufs.Dota2.CMsgCheerState.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCReportCheerState> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCReportCheerState](Divine.Protobufs.Dota2.CMsgServerToGCReportCheerState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCReportCheerState Clone()
```

#### Returns

 [CMsgServerToGCReportCheerState](Divine.Protobufs.Dota2.CMsgServerToGCReportCheerState.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_Equals_Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_"></a> Equals\(CMsgServerToGCReportCheerState\)

```csharp
public bool Equals(CMsgServerToGCReportCheerState other)
```

#### Parameters

`other` [CMsgServerToGCReportCheerState](Divine.Protobufs.Dota2.CMsgServerToGCReportCheerState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_"></a> MergeFrom\(CMsgServerToGCReportCheerState\)

```csharp
public void MergeFrom(CMsgServerToGCReportCheerState other)
```

#### Parameters

`other` [CMsgServerToGCReportCheerState](Divine.Protobufs.Dota2.CMsgServerToGCReportCheerState.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCReportCheerState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

