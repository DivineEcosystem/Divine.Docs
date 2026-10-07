# <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData"></a> Class CMsgLobbyPlayerPlusSubscriptionData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyPlayerPlusSubscriptionData : IMessage<CMsgLobbyPlayerPlusSubscriptionData>, IEquatable<CMsgLobbyPlayerPlusSubscriptionData>, IDeepCloneable<CMsgLobbyPlayerPlusSubscriptionData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md)

#### Implements

IMessage<CMsgLobbyPlayerPlusSubscriptionData\>, 
[IEquatable<CMsgLobbyPlayerPlusSubscriptionData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyPlayerPlusSubscriptionData\>, 
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
[EnumerableExtensions.In<CMsgLobbyPlayerPlusSubscriptionData\>\(CMsgLobbyPlayerPlusSubscriptionData, params CMsgLobbyPlayerPlusSubscriptionData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData__ctor"></a> CMsgLobbyPlayerPlusSubscriptionData\(\)

```csharp
public CMsgLobbyPlayerPlusSubscriptionData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData__ctor_Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_"></a> CMsgLobbyPlayerPlusSubscriptionData\(CMsgLobbyPlayerPlusSubscriptionData\)

```csharp
public CMsgLobbyPlayerPlusSubscriptionData(CMsgLobbyPlayerPlusSubscriptionData other)
```

#### Parameters

`other` [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_HeroBadgesFieldNumber"></a> HeroBadgesFieldNumber

```csharp
public const int HeroBadgesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_HeroBadges"></a> HeroBadges

```csharp
public RepeatedField<CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge> HeroBadges { get; }
```

#### Property Value

 RepeatedField<[CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.md).[HeroBadge](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.Types.HeroBadge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyPlayerPlusSubscriptionData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyPlayerPlusSubscriptionData Clone()
```

#### Returns

 [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_Equals_Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_"></a> Equals\(CMsgLobbyPlayerPlusSubscriptionData\)

```csharp
public bool Equals(CMsgLobbyPlayerPlusSubscriptionData other)
```

#### Parameters

`other` [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_"></a> MergeFrom\(CMsgLobbyPlayerPlusSubscriptionData\)

```csharp
public void MergeFrom(CMsgLobbyPlayerPlusSubscriptionData other)
```

#### Parameters

`other` [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlayerPlusSubscriptionData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

