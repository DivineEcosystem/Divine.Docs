# <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach"></a> Class CMsgPracticeLobbySetCoach

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPracticeLobbySetCoach : IMessage<CMsgPracticeLobbySetCoach>, IEquatable<CMsgPracticeLobbySetCoach>, IDeepCloneable<CMsgPracticeLobbySetCoach>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPracticeLobbySetCoach](Divine.Protobufs.Dota2.CMsgPracticeLobbySetCoach.md)

#### Implements

IMessage<CMsgPracticeLobbySetCoach\>, 
[IEquatable<CMsgPracticeLobbySetCoach\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPracticeLobbySetCoach\>, 
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
[EnumerableExtensions.In<CMsgPracticeLobbySetCoach\>\(CMsgPracticeLobbySetCoach, params CMsgPracticeLobbySetCoach\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach__ctor"></a> CMsgPracticeLobbySetCoach\(\)

```csharp
public CMsgPracticeLobbySetCoach()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach__ctor_Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_"></a> CMsgPracticeLobbySetCoach\(CMsgPracticeLobbySetCoach\)

```csharp
public CMsgPracticeLobbySetCoach(CMsgPracticeLobbySetCoach other)
```

#### Parameters

`other` [CMsgPracticeLobbySetCoach](Divine.Protobufs.Dota2.CMsgPracticeLobbySetCoach.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPracticeLobbySetCoach> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPracticeLobbySetCoach](Divine.Protobufs.Dota2.CMsgPracticeLobbySetCoach.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_Team"></a> Team

```csharp
public DOTA_GC_TEAM Team { get; set; }
```

#### Property Value

 [DOTA\_GC\_TEAM](Divine.Protobufs.Dota2.DOTA\_GC\_TEAM.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_Clone"></a> Clone\(\)

```csharp
public CMsgPracticeLobbySetCoach Clone()
```

#### Returns

 [CMsgPracticeLobbySetCoach](Divine.Protobufs.Dota2.CMsgPracticeLobbySetCoach.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_Equals_Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_"></a> Equals\(CMsgPracticeLobbySetCoach\)

```csharp
public bool Equals(CMsgPracticeLobbySetCoach other)
```

#### Parameters

`other` [CMsgPracticeLobbySetCoach](Divine.Protobufs.Dota2.CMsgPracticeLobbySetCoach.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_MergeFrom_Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_"></a> MergeFrom\(CMsgPracticeLobbySetCoach\)

```csharp
public void MergeFrom(CMsgPracticeLobbySetCoach other)
```

#### Parameters

`other` [CMsgPracticeLobbySetCoach](Divine.Protobufs.Dota2.CMsgPracticeLobbySetCoach.md)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPracticeLobbySetCoach_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

